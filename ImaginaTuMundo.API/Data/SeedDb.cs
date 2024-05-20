using ImaginaTuMundo.API.Helpers;
using ImaginaTuMundo.Shared.Entidades;
using ImaginaTuMundo.Shared.Enums;

namespace ImaginaTuMundo.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            await CheckAsociacionAsync();

            await CheckRoleAsync();

            await CheckUserAsync("10140", "Super", "Admin", "dacanad@gnmail.com", "3232942877", "Cr 108a", UserType.Admin);
        }

        private async Task CheckRoleAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.Madre.ToString());
            await _userHelper.CheckRoleAsync(UserType.ICBF.ToString());
            await _userHelper.CheckRoleAsync(UserType.Representante.ToString());
        }

        private async Task<User> CheckUserAsync(string documento, string nombre, string apellido, string email, string celular, string direccion, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {

                    Documento = documento,
                    Nombre = nombre,
                    Apellido = apellido,
                    PhoneNumber = celular,
                    Email = email,
                    UserName = email,
                    Direccion = direccion,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }

            return user;
        }

        private async Task CheckAsociacionAsync()
        {
            if (!_context.Asociaciones.Any())
            {
                _context.Asociaciones.Add(new Asociacion
                {
                    Nombre = "Margaritas",
                    Nit = "111",
                    Rut = "11111",
                    Direccion = "Cr Margaritas",
                    Barrio = "Robledo Margaritas",
                    Celular = "323221231",
                    CorreoElectronico = "111@gmail.com",
                    RepresentacionJuridica = "No sé c:"
                });

                _context.Asociaciones.Add(new Asociacion
                {
                    Nombre = "San Cristobal",
                    Nit = "222",
                    Rut = "222222",
                    Direccion = "Cr San Cristobal",
                    Barrio = "San Cristobal",
                    Celular = "3242456255",
                    CorreoElectronico = "222@gmail.com",
                    RepresentacionJuridica = "No sé c:"
                });
            }

            await _context.SaveChangesAsync();
        }
    }
}
