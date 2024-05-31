using BlazorPeliculas.Shared.DTOs;
using System.Reflection.Metadata;

namespace BlazorPeliculas.Client.Auth
{
    public interface ILoginService
    {
        Task Login(UserTokenDTO tokenDTO);
        Task Logout();
        Task ManejarRenovacionToken();
    }
}
