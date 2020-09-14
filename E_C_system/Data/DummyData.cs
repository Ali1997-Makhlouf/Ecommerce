using E_C_system.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace E_C_system.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<Client> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();
            String adminId = "";
            String adminId1 = "";
            String adminId2 = "";

            string role = "Owner";
            string desc = "This is the Owner role";

            string role1 = "Admin";
            string desc1 = "This is the administrator role";

            string role2 = "User";
            string desc2 = "This is the members role";

            string password = "Test@2020";
            if (await roleManager.FindByNameAsync(role) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role, desc, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
            if (await userManager.FindByNameAsync("owner@gmail.com") == null)
            {
                var user = new Client
                {
                    UserName = "Owner",
                    Email = "owner@gmail.com",
                    PhoneNumber = "0999999999"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role);
                }
                adminId = user.Id;
            }
            if (await userManager.FindByNameAsync("admin@gmail.com") == null)
            {
                var user = new Client
                {
                    UserName = "Admin",
                    Email = "admin@gmail.com",
                    PhoneNumber = "9938383"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("user@gmail.com") == null)
            {
                var user = new Client
                {
                    UserName = "User",
                    Email = "user@gmail.com",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                adminId2 = user.Id;
            }

            //if (await userManager.FindByNameAsync("mm@mm.mm") == null)
            //{
            //    var user = new Client
            //    {
            //        UserName = "mm@mm.mm",
            //        Email = "mm@mm.mm",
            //        PhoneNumber = "6572136821"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role2);
            //    }
            //}

            //if (await userManager.FindByNameAsync("dd@dd.dd") == null)
            //{
            //    var user = new Client
            //    {
            //        UserName = "dd@dd.dd",
            //        Email = "dd@dd.dd",
            //        PhoneNumber = "6041234567"
            //    };

            //    var result = await userManager.CreateAsync(user);
            //    if (result.Succeeded)
            //    {
            //        await userManager.AddPasswordAsync(user, password);
            //        await userManager.AddToRoleAsync(user, role2);
            //    }
            //}
        }
    }
}
