using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.ViewModel;

namespace TechAdvocacia.Application.Services.Interfaces
{
    public interface IClienteService
    {
        public List<ClienteViewModel> GetAll();
        public ClienteViewModel? GetById(int id);
        public int Create(NewClienteInputModel medico);
        public void Update(int id, NewClienteInputModel medico);
        public void Delete(int id);
    }
}