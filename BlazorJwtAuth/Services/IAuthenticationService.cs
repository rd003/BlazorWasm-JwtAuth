using BlazorJwtAuth.Models;

namespace BlazorJwtAuth.Services
{
    public interface IAuthenticationService
    {
        Task<LoginResponse> Login(LoginDTO model);
        Task Logout();
    }
}