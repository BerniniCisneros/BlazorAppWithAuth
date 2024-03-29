﻿using Microsoft.AspNetCore.Identity;
using Models;

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
                    FirstName = "Norberto",
                    LastName = "Valdez",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "norberto",
                    NormalizedUserName = "NORBERTO",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new ApplicationUser
                {
                    FirstName = "Alejandro",
                    LastName = "Blanco",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "alejandro",
                    NormalizedUserName = "ALEJANDRO",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new ApplicationUser
                {
                    FirstName = "Bernini",
                    LastName = "Cisneros",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "bernini",
                    NormalizedUserName = "BERNINI",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new ApplicationUser
                {
                    FirstName = "Samuel",
                    LastName = "Silva",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "samuel",
                    NormalizedUserName = "SAMUEL",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new ApplicationUser
                {
                    FirstName = "Manuel",
                    LastName = "Robles",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "manuel",
                    NormalizedUserName = "MANUEL",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                },
                new ApplicationUser
                {
                    FirstName = "Luis Fernando",
                    LastName = "Valdez",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    UserName = "luis",
                    NormalizedUserName = "LUIS",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                }
            };

            var passwords = new Dictionary<string, string>()
            {
                { "tito", "titoLV123" },
                { "norberto", "norberLV123" },
                { "alejandro", "alexLV123" },
                { "bernini", "polliLV123" },
                { "samuel", "samLV123" },
                { "manuel", "manuelLV123" },
                { "luis", "luisfervalLV123" }
            };
            
            foreach (var user in captains)
            {
                var aspnetUser = await userManager.FindByNameAsync(user.UserName);
                if (aspnetUser is not null)
                {
                    await userManager.DeleteAsync(aspnetUser);
                }
            }
            foreach (var user in captains)
            {
                if (await userManager.FindByNameAsync(user.UserName) is not null) return;
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, passwords[user.UserName]);
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
                var aspnetUser = await userManager.FindByNameAsync(user.UserName);
                if (aspnetUser is not null)
                {
                    await userManager.DeleteAsync(aspnetUser);
                }
            }
            foreach (var user in overseers)
            {
                if (await userManager.FindByNameAsync(user.UserName) is not null) return;
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, passwords[user.UserName]);
                user.PasswordHash = hashed;

                var result = await userManager.CreateAsync(user);
                //assign all role to super admin
                await userManager.AddToRolesAsync(await userManager.FindByNameAsync(user.UserName), roles.Where(s => s != "Captain").Select(x => x.ToUpper()));
            }

        }
    }
}
