using Microsoft.AspNetCore.Identity;

namespace BlazorAppWithAuth.Data
{
    public class AppUserSeeder
    {
        public static async void Initialize(IServiceProvider serviceProvider, IServiceScope scope)
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            string[] roles = { "Overseer", "Captain" };

            foreach (var role in roles)
            {
                if (!(await roleManager.RoleExistsAsync(role)))
                {
                    await roleManager.CreateAsync(new ApplicationRole() { Name = role, NormalizedName = role.ToUpper() });
                }
            }

            var captains = new ApplicationUser[]
            {
                new ApplicationUser
                {
                    FirstName = "Alejandro",
                    LastName = "Blanco",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "alejandro",
                    NormalizedUserName = "ALEX",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                }
            };

            foreach (var user in captains)
            {
                if (await userManager.FindByNameAsync(user.UserName) is not null) return;
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "secret");
                user.PasswordHash = hashed;

                var result = await userManager.CreateAsync(user);
                //assign all role to super admin
                await userManager.AddToRolesAsync(await userManager.FindByNameAsync(user.UserName), roles.Where(s => s != "Overseer").Select(x => x.ToUpper()));
            }

            var overseers = new ApplicationUser[]
            {
                new ApplicationUser
                {
                    FirstName = "Tito",
                    LastName = "Esquivel",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "tito",
                    NormalizedUserName = "TITO",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
            };

            foreach (var user in overseers)
            {
                if (await userManager.FindByNameAsync(user.UserName) is not null) return;
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "secret");
                user.PasswordHash = hashed;

                var result = await userManager.CreateAsync(user);
                //assign all role to super admin
                await userManager.AddToRolesAsync(await userManager.FindByNameAsync(user.UserName), roles);
            }

        }
    }
}
