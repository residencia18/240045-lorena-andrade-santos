

using Escambo.Application.InputModels;
using Escambo.Application.Services.Interfaces;
using Escambo.Application.ViewModels;
using Escambo.WebAPI.Controllers.Interface;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Escambo/")]
public class UsuarioController : ControllerBase, IUsuarioController
{
    protected readonly IUsuarioService _usuarioService;
    public List<UsuarioViewModel> _usuarios  => _usuarioService.GetAll().ToList();

    public UsuarioController(IUsuarioService usuarioService) => _usuarioService = usuarioService;
    [HttpGet("Usuario/all")]
    public IActionResult GetAll()
    {
        if(_usuarios == null) return NotFound();

        return Ok(_usuarios); 
    }

    [HttpPost("Usuario")]
    public IActionResult Create(UsuarioInputModel input)
    {
       var id =  _usuarioService.Create(input);
       if(id == 0) return BadRequest();
       return Ok(id);
    }

    [HttpGet("Usuario/{id}")]
    public IActionResult GetById(int id)
    {
        var _usuarios = _usuarioService.GetById(id);
        if(_usuarios is not null)  return Ok(_usuarios);
        
        return NotFound();
       
    }

    [HttpPut("Usuario/{id}")]
    public IActionResult Update(int id, UsuarioInputModel input)
    {
        _usuarioService.Update(id, input);
        return Ok();
    }

    [HttpDelete("Usuario/{id}")]
    public IActionResult Delete(int id)
    {
        _usuarioService.Delete(id);
        return Ok();
    }

    [HttpGet("Usuarios/Anuncio/")]
    public IActionResult GetAnunciosByUsuarios(int id)
    {
        
        var anucios = _usuarios;
        if (anucios is not null) return Ok(anucios);
        return NotFound();
    }

    [HttpGet("Usuario/{id}/Anuncio/")]
    public IActionResult GetAnunciosByUsuario(int id){

        var anucios = _usuarios.Where(u => u.Anuncios.Any(a => a.AnuncioId == id)).ToList();
        if(anucios is not null) return Ok(anucios);
        return NotFound();                                       
    }


}