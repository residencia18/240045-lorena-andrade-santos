using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.ViewModel;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Application.Services.Interfaces
{
    public interface IAdvogadoService
    {
        
        public List<AdvogadoViewModel> GetAll();
        public AdvogadoViewModel? GetById(int id);
        public int Create(NewAdvogadoInputModel advogado);
        public void Update(int id, NewAdvogadoInputModel advogado);
        public void Delete(int id);
    }
}