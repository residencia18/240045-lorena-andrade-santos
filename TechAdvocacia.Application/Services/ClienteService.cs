using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.Services.Interfaces;
using TechAdvocacia.Application.ViewModel;
using TechAdvocacia.Infra;

namespace TechAdvocacia.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly TechAdvocaciaDbContext _context;
        public ClienteService(TechAdvocaciaDbContext context){
            _context = context;
        }
        
        public int Create(NewClienteInputModel medico)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, NewClienteInputModel medico)
        {
            throw new NotImplementedException();
        }
    }
}