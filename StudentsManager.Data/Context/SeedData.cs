using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StudentsManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsManager.Data
{ 
    public static class SeedData
    {
        public static IWebHost Seed(this IWebHost webhost)
        {
            using (var scope = webhost.Services.GetService<IServiceScopeFactory>().CreateScope())
            {
                // alternatively resolve UserManager instead and pass that if only think you want to seed are the users     
                using (var dbContext = scope.ServiceProvider.GetRequiredService<StudentsManagerContext>())
                {
                    SeedData.SeedAsync(dbContext).GetAwaiter().GetResult();
                }
                return webhost;
            }
        }

        public static async Task SeedAsync(StudentsManagerContext context)
        { 
            context.Database.EnsureCreated();

            if (context.Student.Any())
            {
                return;
            }

            context.Student.Add(new Student()
            {
                FirstName = "Anderson",
                Surname = "Martins",
                Gender = "Male",
                DOB = "Unknown",
                Course = new Course() { Name = "Computer Science" },
                Addresses = new List<Address>() { new Address() { Street = "Eng Manoel Ferramenta Jr Street 363", PostalCode = "11086-400", City = "Santos", State = "Sao Paulo", Country = "Brazil" } }
            });

            context.Student.Add(new Student()
            {
                FirstName = "Roberta",
                Surname = "Martins",
                Gender = "Female",
                DOB = "Unknown",
                Course = new Course() { Name = "Pedagody" },
                Addresses = new List<Address>() { new Address() { Street = "Rua Santo Melarato 41", PostalCode = "11390-030", City="Sao Vicente", State = "Sao Paulo", Country= "Brazil" } }
            });

            await context.SaveChangesAsync();
        }
    }
}
