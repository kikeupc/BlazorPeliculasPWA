using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace BlazorPeliculas.Client.Auth
{
    public class ProveedorAutenticacionPrueba : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimo = new ClaimsIdentity(); // Un Claim es un dato del usuario, ejm: nombre, fecha nacimiento
            var usuarioEnrique = new ClaimsIdentity(
                new List<Claim>
                {
                    new Claim("llave1", "valor1"),
                    new Claim("edad", "99"),
                    new Claim(ClaimTypes.Name, "Enrique"),
                    new Claim(ClaimTypes.Role, "admin")
                },
                authenticationType: "prueba");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonimo)));
        }
    }
}
