using Escambo.Application.Services.Security;
using Escambo.Infra.Context;
using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Auth;

namespace Escambo.Application.Services;

public class LoginService : ILoginService
{
    private readonly EscamboContext _context;
    private readonly IAuthService _authService;
    public LoginService(EscamboContext context, IAuthService authService){
        _context = context;
        _authService = authService;
    }
    public LoginViewModel? Authenticate(LoginInputModel login)
    {
        string _token = "";
        var _password = Utils.HashPassword(login.Password);//criptografa a senha inserida

        var user = _context.Usuarios
            .FirstOrDefault(x => x.Email== login.Username && x.Senha == _password);//suponha que a senha está sendo salva criptografada

        if (user is not null)
        {
            if(user.Senha == _password && user.Email == login.Username){
                _token = _authService.GenerateJwtToken(login.Username, "User");

                if (_token !=""){
                    return new LoginViewModel
                    {
                        Username = user.Email,
                        Token = _token,
                    };
                }
            }
            
           
        }
       
       return null;
    }
}