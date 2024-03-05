using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechAdvocacia.Application.InputModel;
using TechAdvocacia.Application.Services.Interfaces;
using TechAdvocacia.Application.ViewModel;

namespace TechAdvogado.webAPI.Controllers
{

    [ApiController]
    [Route("/api/v0.1/")]
    public class ClienteController : ControllerBase
    {
        
        private readonly IClienteService _clienteService;
        public List<ClienteViewModel> Clientes => _clienteService.GetAll();
        public ClienteController(IClienteService service) => _clienteService = service;

        [HttpGet("clientes")]
        public IActionResult Get()
        {
            return Ok(Clientes);
        }
        [HttpGet("cliente/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var cliente = _clienteService.GetById(id);
                return Ok(cliente);
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("cliente")]
        public IActionResult Post([FromBody] NewClienteInputModel cliente)
        {
            _clienteService.Create(cliente);

            //service.Create(paciente);
            return CreatedAtAction(nameof(Get), cliente);
        
        }


        [HttpPut("cliente/{id}")]
        public IActionResult Put(int id, [FromBody] NewClienteInputModel cliente)
        {
            if (_clienteService.GetById(id) == null)
                return NoContent();
            _clienteService.Update(id, cliente);
            return Ok(_clienteService.GetById(id));
        }
         [HttpDelete("cliente/{id}")]
        public IActionResult Delete(int id)
        {
            if (_clienteService.GetById(id) == null)
                return NoContent();
            _clienteService.Delete(id);
            return Ok();
        }
        }

}