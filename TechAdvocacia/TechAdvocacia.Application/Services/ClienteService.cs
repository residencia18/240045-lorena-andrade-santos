using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.Services.Interfaces;
using TechAdvocacia.Application.ViewModel;
using TechAdvocacia.Core.Entities;
using TechAdvocacia.Core.Exceptions;
using TechAdvocacia.Infra;

namespace TechAdvocacia.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly TechAdvocaciaDbContext _context;

        public ClienteService(TechAdvocaciaDbContext context)
        {
            _context = context;
        }

        public int Create(NewClienteInputModel medico)
        {
            var _cliente = new Cliente
            {
                Nome = medico.Nome
            };
            _context.Clientes.Add(_cliente);

            _context.SaveChanges();

            return _cliente.ClienteId;
        }

        public void Delete(int id)
        {
            _context.Clientes.Remove(GetByDbId(id)!);

            _context.SaveChanges();
        }

        public List<ClienteViewModel> GetAll()
        {
            var _clientes = _context.Clientes.Select(m => new ClienteViewModel
            {
                ClienteId = m.ClienteId,
                Nome = m.Nome
            }).ToList();

            return _clientes;
        }

        private Cliente? GetByDbId(int id)
        {
            var _cliente = _context.Clientes.Find(id);

            if (_cliente is null)
                throw new ClienteNotFoundException();

            return _cliente;
        }

        public ClienteViewModel? GetById(int id)
        {
            var _cliente = GetByDbId(id);

            var clienteViewModel = new ClienteViewModel
            {
                ClienteId = _cliente!.ClienteId,
                Nome = _cliente.Nome
            };
            return clienteViewModel;
        }
        public void Update(int id, NewClienteInputModel cliente)
        {
            var _cliente = GetByDbId(id)!;

            _cliente.Nome = cliente.Nome;

            _context.Clientes.Update(_cliente);

            _context.SaveChanges();
        }
    }
}