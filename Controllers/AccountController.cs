using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sistema_De_Ahorro_y_Prestamos_v2.Data.Enum;
using Sistema_De_Ahorro_y_Prestamos_v2.Models;
using Sistema_De_Ahorro_y_Prestamos_v2.Repositorio;
using Sistema_De_Ahorro_y_Prestamos_v2.ViewModels;

namespace Sistema_De_Ahorro_y_Prestamos_v2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager , SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        } 

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login() {
            var response = new LoginViewModel();
            return View(response);
        } 
        [HttpPost]
        public async Task <IActionResult> Login(LoginViewModel loginViewModel) 
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
           if(user != null)
            {

                var checked_password =  await _userManager.CheckPasswordAsync(user, loginViewModel.Password);

                if (checked_password)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Dash", "Home");


                    }

                }
                // password invalid
                TempData["Error"] = "Error with password";
                return View(loginViewModel);
            }
            TempData["Error"] = "User not found";
            return View(loginViewModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            var response = new RegisterViewModel();
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);
            var User = await _userManager.FindByEmailAsync(registerViewModel.Email);
            if(User != null)
            {
                TempData["Error"] = "Address already in Use";
                return View(registerViewModel);
            }
            var NewUser = new User()
            {
                Email =  registerViewModel.Email,
                UserName = registerViewModel.Email


            };

            var newUserResponse = await _userManager.CreateAsync(NewUser, registerViewModel.Password);

            if (newUserResponse.Succeeded)
            
            await _userManager.AddToRoleAsync(NewUser, Roles.User);
            
            return RedirectToAction("Dash","Home");


        }

        [HttpPost]
        public async Task <IActionResult> LogOut() {

            await _signInManager.SignOutAsync();
              return RedirectToAction("Index", "Home");
        
        }

    }

}
