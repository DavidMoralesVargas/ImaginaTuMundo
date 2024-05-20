
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ImaginaTuMundo.API.Helpers;
using ImaginaTuMundo.Shared.DTOs;
using ImaginaTuMundo.Shared.Entidades;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;


namespace ImaginaTuMundo.API.Controllers
{
    [ApiController]
    [Route("/api/accounts")]

    public class AccountsController : ControllerBase
    {

        private readonly IUserHelper _userHelper;
        private readonly IConfiguration _configuration;
        private readonly IFileStorage _fileStorage;
        private readonly string _container;


        public AccountsController(IUserHelper userHelper, IConfiguration configuration, IFileStorage fileStorage)
        {
            _userHelper = userHelper;
            _configuration = configuration;
            _fileStorage = fileStorage;
            _container = "users";

        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] UserDTO model)
        {
            User user = model;
            if (!string.IsNullOrEmpty(model.Foto))
            {
                var photoUser = Convert.FromBase64String(model.Foto);
                model.Foto = await _fileStorage.SaveFileAsync(photoUser, ".jpg", _container);
            }


            var result = await _userHelper.AddUserAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _userHelper.AddUserToRoleAsync(user, user.UserType.ToString());
                return Ok(BuildToken(user));
            }

            return BadRequest(result.Errors.FirstOrDefault());
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login([FromBody] LoginDTO model)
        {
            var result = await _userHelper.LoginAsync(model);
            if (result.Succeeded)
            {
                var user = await _userHelper.GetUserAsync(model.Email);
                return Ok(BuildToken(user));
            }

            return BadRequest("Email o contraseña incorrectos.");
        }

        private TokenDTO BuildToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email!),
                new Claim(ClaimTypes.Role, user.UserType.ToString()),
                new Claim("Documento", user.Documento),
                new Claim("Nombre", user.Nombre),
                new Claim("Apellido", user.Apellido),
                new Claim("Dirección", user.Direccion),
                new Claim("Foto", user.Foto ?? string.Empty)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwtKey"]!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddDays(30);
            var token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: credentials);

            return new TokenDTO
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

        [HttpPut]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> Put(User user)
        {
            try
            {
                if (!string.IsNullOrEmpty(user.Foto))
                {
                    var photoUser = Convert.FromBase64String(user.Foto);
                    user.Foto = await _fileStorage.SaveFileAsync(photoUser, ".jpg", _container);
                }

                var currentUser = await _userHelper.GetUserAsync(user.Email!);
                if (currentUser == null)
                {
                    return NotFound();
                }

                currentUser.Documento = user.Documento;
                currentUser.Nombre = user.Nombre;
                currentUser.Apellido = user.Apellido;
                currentUser.Direccion = user.Direccion;
                currentUser.PhoneNumber = user.PhoneNumber;
                currentUser.Foto = !string.IsNullOrEmpty(user.Foto) && user.Foto != currentUser.Foto ? user.Foto : currentUser.Foto;

                var result = await _userHelper.UpdateUserAsync(currentUser);
                if (result.Succeeded)
                {
                    return NoContent();
                }

                return BadRequest(result.Errors.FirstOrDefault());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult> Get()
        {
            return Ok(await _userHelper.GetUserAsync(User.Identity!.Name!));
        }

    }
}


