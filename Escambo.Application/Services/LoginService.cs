using Escambo.Application.Services.Security;
using Escambo.Infra.Context;
using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;

namespace Escambo.Application.Services;

public class LoginService : ILoginService
{
    private readonly EscamboContext _context;
    public LoginService(EscamboContext context){
        _context = context;
    }
    public LoginViewModel? Authenticate(LoginInputModel login)
    {
        string _token = "";
        var _password = Utils.HashPassword(login.Password);//criptografa a senha inserida

        var user = _context.Usuarios
            .FirstOrDefault(x => x.Email== login.Username && x.Senha == _password);//suponha que a senha está sendo salva criptografada

        if (user is not null)
        {
            // _token = TokenService.GenerateToken(user);  gere o token aqui
            return new LoginViewModel
            {
                Username = user.Email,
                Token = _token,
            };
        }
       
       return null;
    }
}