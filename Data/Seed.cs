using Microsoft.AspNetCore.Identity;
using Sistema_De_Ahorro_y_Prestamos_v2.Data.Enum;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
namespace Sistema_De_Ahorro_y_Prestamos_v2.Data
{
public class Seed
{
    public static async Task SeedUserAndRoles(IApplicationBuilder applicationBuilder){
     using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope()){

        var roleManager= serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        
        if(!await roleManager.RoleExistsAsync(Roles.Admin))
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin));
        if(!await roleManager.RoleExistsAsync(Roles.User))
            await roleManager.CreateAsync(new IdentityRole(Roles.User));

            var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();

            string adminUserEmail = "adrian944uchiha@gmail.com";

            var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
            if(adminUser == null){

         var NewAdminUser = new User(){
           
           UserName = "1AdrianM",
           Email = adminUserEmail, 
           EmailConfirmed = true
           
         };

     await userManager.CreateAsync(NewAdminUser, "Axe72h");
     await userManager.AddToRoleAsync(NewAdminUser, Roles.Admin);

  }
  
  string User = "njadaka2525@gmail.com";
  var User_basic = await userManager.FindByEmailAsync(User);
            if(User_basic == null){

         var User_1 = new User(){
           
           UserName = "1AdrianM",
           Email = adminUserEmail, 
           EmailConfirmed = true
           
         };

     await userManager.CreateAsync(User_1, "12345678A");
     await userManager.AddToRoleAsync(User_1, Roles.User);

       }

     }
  }
}
}