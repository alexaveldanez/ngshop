using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager) 
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Bill",
                    Email = "bill@test.com",
                    UserName = "bill@test.com",
                    Address = new Address
                    {
                        FirstName = "Bill",
                        LastName = "Billy",
                        Street = "1st Street",
                        City = "San Diego",
                        State = "CA",
                        ZipCode = "91910"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}