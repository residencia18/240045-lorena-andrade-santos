using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escambo.Application.InputModels;
using Escambo.Application.Services.Interfaces;
using Escambo.Application.ViewModels;
using Escambo.Dommain.Model;
using Escambo.Infra.Context;

namespace Escambo.Application.Services
{
    public class PrestacaoServicoService : IPrestacaoServicoService
    {
        private readonly EscamboContext _context;

        public PrestacaoServicoService(EscamboContext context)
        {
            _context = context;
        }

        public int Create(PrestacaoServicoInputModel prestacao)
        {
            var novaPrestacao = new PrestacaoServico
            {
                Descrição = prestacao.Descrição,
                Categoria = prestacao.Categoria,
                Tipo = prestacao.Tipo,
                Status = prestacao.Status,
                Duração = prestacao.Duração,
                Data = prestacao.Data,
                Credito = prestacao.Credito,
                ContratanteId = prestacao.ContratanteId,
                PrestadorId = prestacao.PrestadorId,
                AnuncioIdAnuncio = prestacao.AnuncioIdAnuncio
            };

            _context.PrestacaoServicos.Add(novaPrestacao);
            _context.SaveChanges();

            return novaPrestacao.PrestacaoServicoId;
        }

        public void Delete(int id)
        {
            var prestacaoToDelete = _context.PrestacaoServicos.Find(id);

            if (prestacaoToDelete == null)
                return;

            _context.PrestacaoServicos.Remove(prestacaoToDelete);
            _context.SaveChanges();
        }

        public List<PrestacaoServicoViewModel> GetAll()
        {
            var prestacoes = _context.PrestacaoServicos
                .Select(p => new PrestacaoServicoViewModel
                {
                    PrestacaoServicoId = p.PrestacaoServicoId,
                    ServiçoId = p.ServiçoId,
                    Descrição = p.Descrição,
                    Categoria = p.Categoria,
                    Tipo = p.Tipo,
                    Status = p.Status,
                    Duração = p.Duração,
                    Data = p.Data,
                    Credito = p.Credito,
                    ContratanteId = p.ContratanteId,
                    PrestadorId = p.PrestadorId,
                    AnuncioIdAnuncio = p.AnuncioIdAnuncio
                })
                .ToList();

            return prestacoes;
        }

        public PrestacaoServicoViewModel? GetById(int id)
        {
            var prestacao = _context.PrestacaoServicos.Find(id);

            if (prestacao == null)
                return null;

            var prestacaoViewModel = new PrestacaoServicoViewModel
            {
                PrestacaoServicoId = prestacao.PrestacaoServicoId,
                ServiçoId = prestacao.ServiçoId,
                Descrição = prestacao.Descrição,
                Categoria = prestacao.Categoria,
                Tipo = prestacao.Tipo,
                Status = prestacao.Status,
                Duração = prestacao.Duração,
                Data = prestacao.Data,
                Credito = prestacao.Credito,
                ContratanteId = prestacao.ContratanteId,
                PrestadorId = prestacao.PrestadorId,
                AnuncioIdAnuncio = prestacao.AnuncioIdAnuncio
            };

            return prestacaoViewModel;
        }

        public void Update(int id, PrestacaoServicoInputModel prestacao)
        {
            var prestacaoToUpdate = _context.PrestacaoServicos.Find(id);

            if (prestacaoToUpdate == null)
                return;

            prestacaoToUpdate.Descrição = prestacao.Descrição;
            prestacaoToUpdate.Categoria = prestacao.Categoria;
            prestacaoToUpdate.Tipo = prestacao.Tipo;
            prestacaoToUpdate.Status = prestacao.Status;
            prestacaoToUpdate.Duração = prestacao.Duração;
            prestacaoToUpdate.Data = prestacao.Data;
            prestacaoToUpdate.Credito = prestacao.Credito;
            prestacaoToUpdate.ContratanteId = prestacao.ContratanteId;
            prestacaoToUpdate.PrestadorId = prestacao.PrestadorId;
            prestacaoToUpdate.AnuncioIdAnuncio = prestacao.AnuncioIdAnuncio;

            _context.SaveChanges();
        }
    }
}
