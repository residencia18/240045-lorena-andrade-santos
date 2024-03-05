using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.ViewModel;

namespace TechAdvocacia.Application.Services.Interfaces
{
    public interface IDocumentoService
    { 
        public List<DocumentoViewModel> GetAll();
        public DocumentoViewModel? GetById(int id);
        public int Create(NewDocumentoInputModel documento);
        public void Update(int id, NewDocumentoInputModel documento);
        public void Delete(int id);
    }
}