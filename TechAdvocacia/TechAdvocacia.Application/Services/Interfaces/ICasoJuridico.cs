using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.ViewModel;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Application.Services.Interfaces
{
    public interface ICasoJuridico
    {
        
        public List<CasoJuridicoViewModel> GetAll();
        public CasoJuridicoViewModel? GetById(int id);
        public int Create(NewCasoJuridicoInputModel casoJuridico);
        public void Update(int id, NewClienteInputModel casoJuridico);
        public void Delete(int id);
    }
}