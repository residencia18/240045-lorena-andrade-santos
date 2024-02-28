using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escambo.Application.InputModels;
using Escambo.Application.Services.Interfaces;
using Escambo.Application.ViewModels;
using Escambo.Dommain.Model;
using Escambo.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Escambo.Application.Services
{
    public class MensagemService : IMensagemService
    {
        private readonly EscamboContext _context;

        public MensagemService(EscamboContext context)
        {
            _context = context;
        }

        public int Create(MensagemInputModel mensagem)
        {
            var novaMensagem = new Mensagem
            {
                Texto = mensagem.Texto,
                DataEnvio = mensagem.DataEnvio,
                HoraEnvio = mensagem.HoraEnvio,
                ConversaId = mensagem.ConversaId,
                UsuariosIdUsuario = mensagem.UsuariosIdUsuario
            };

            _context.Mensagens.Add(novaMensagem);
            _context.SaveChanges();

            return novaMensagem.MensagemId;
        }

        public void Delete(int id)
        {
            var mensagemToDelete = _context.Mensagens.Find(id);

            if (mensagemToDelete == null)
                return;

            _context.Mensagens.Remove(mensagemToDelete);
            _context.SaveChanges();
        }

        public List<MensagemViewModel> GetAll()
        {
            var mensagens = _context.Mensagens
                .Include(m => m.Usuario)
                .Select(m => new MensagemViewModel
                {
                    MensagemId = m.MensagemId,
                    Texto = m.Texto,
                    DataEnvio = m.DataEnvio,
                    HoraEnvio = m.HoraEnvio,
                    ConversaId = m.ConversaId,
                    UsuariosIdUsuario = m.UsuariosIdUsuario,
                    Usuario = new UsuarioViewModel
                    {
                        UsuarioId = m.Usuario.UsuarioId,
                        Email = m.Usuario.Email,
                        Nome = m.Usuario.Nome
                    }
                })
                .ToList();

            return mensagens;
        }

        public MensagemViewModel? GetById(int id)
        {
            var mensagem = _context.Mensagens
                .Include(m => m.Usuario)
                .FirstOrDefault(m => m.MensagemId == id);

            if (mensagem == null)
                return null;

            var mensagemViewModel = new MensagemViewModel
            {
                MensagemId = mensagem.MensagemId,
                Texto = mensagem.Texto,
                DataEnvio = mensagem.DataEnvio,
                HoraEnvio = mensagem.HoraEnvio,
                ConversaId = mensagem.ConversaId,
                UsuariosIdUsuario = mensagem.UsuariosIdUsuario,
                Usuario = new UsuarioViewModel
                {
                    UsuarioId = mensagem.Usuario.UsuarioId,
                    Email = mensagem.Usuario.Email,
                    Nome = mensagem.Usuario.Nome
                }
            };

            return mensagemViewModel;
        }

        public void Update(int id, MensagemInputModel mensagem)
        {
            var mensagemToUpdate = _context.Mensagens.Find(id);

            if (mensagemToUpdate == null)
                return;

            mensagemToUpdate.Texto = mensagem.Texto;
            mensagemToUpdate.DataEnvio = mensagem.DataEnvio;
            mensagemToUpdate.HoraEnvio = mensagem.HoraEnvio;
            mensagemToUpdate.ConversaId = mensagem.ConversaId;
            mensagemToUpdate.UsuariosIdUsuario = mensagem.UsuariosIdUsuario;

            _context.SaveChanges();
        }
    }
}
