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
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly EscamboContext _context;

        public AvaliacaoService(EscamboContext context)
        {
            _context = context;
        }

        public int Create(AvaliacaoInputModel avaliacao)
        {
            var novaAvaliacao = new Avaliacao
            {
                Mensagem = avaliacao.Mensagem,
                Estelas = avaliacao.Estelas
            };

            _context.Avaliacoes.Add(novaAvaliacao);
            _context.SaveChanges();

            return novaAvaliacao.AvaliacaoId;
        }

        public void Delete(int id)
        {
            var avaliacao = _context.Avaliacoes.Find(id);

            if (avaliacao != null)
            {
                _context.Avaliacoes.Remove(avaliacao);
                _context.SaveChanges();
            }
        }

        public List<AvaliacaoViewModel> GetAll()
        {
            var avaliacoes = _context.Avaliacoes
                .Select(a => new AvaliacaoViewModel
                {
                    AvaliacaoId = a.AvaliacaoId,
                    Mensagem = a.Mensagem,
                    Estelas = a.Estelas
                })
                .ToList();

            return avaliacoes;
        }

        public AvaliacaoViewModel? GetById(int id)
        {
            var avaliacao = _context.Avaliacoes.Find(id);

            if (avaliacao == null)
                return null;

            var avaliacaoViewModel = new AvaliacaoViewModel
            {
                AvaliacaoId = avaliacao.AvaliacaoId,
                Mensagem = avaliacao.Mensagem,
                Estelas = avaliacao.Estelas
            };

            return avaliacaoViewModel;
        }

        public void Update(int id, AvaliacaoInputModel avaliacao)
        {
            var avaliacaoToUpdate = _context.Avaliacoes.Find(id);

            if (avaliacaoToUpdate != null)
            {
                avaliacaoToUpdate.Mensagem = avaliacao.Mensagem;
                avaliacaoToUpdate.Estelas = avaliacao.Estelas;

                _context.SaveChanges();
            }
        }
    }
}
