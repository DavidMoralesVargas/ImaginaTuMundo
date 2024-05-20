using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;


namespace ImaginaTuMundo.WEB.AuthenticationProviders
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var anonimous = new ClaimsIdentity();
            var oapUser = new ClaimsIdentity(new List<Claim>
        {
            new Claim("Nombre", "Super"),
            new Claim("Apellido", "Admin"),
            new Claim(ClaimTypes.Name, "dacanad@gnmail.com"),
            new Claim(ClaimTypes.Role, "Admin")
        },
        authenticationType: "test");

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(oapUser)));
        }

    }
}
