using System.Threading.Tasks;
using AutoMapper;
using Compelover.Entities.Tangible;
using Compelover.WEBUI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Compelover.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var signUpUser = _mapper.Map<AppUser>(userViewModel);
                IdentityResult result = await _userManager.CreateAsync(signUpUser, userViewModel.Password);
                if (result.Succeeded)
                {
                    // string confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(signUpUser);
                    // string link = Url.Action("ConfirmEmail", "Home", new
                    // {
                    //     userId = signUpUser.Id,
                    //     token = confirmationToken,
                    // }, protocol: HttpContext.Request.Scheme);
                    // TagHelpers.EmailConfirmTagHelper.SendEmailConfirm(link, signUpUser.Email);
                    return RedirectToAction("Login");
                }

                foreach (IdentityError errorMessage in result.Errors)
                {
                    ModelState.AddModelError("", errorMessage.Description);
                }
            }

            return View(userViewModel);
        }

        public IActionResult Login(string returnUrl)
        {
            TempData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user != null) //Kullanıcı var ise
                {
                    // if (_userManager.IsEmailConfirmedAsync(user).Result == false)
                    // {
                    //     ModelState.AddModelError("", "E-Mail Adresi Doğrulanmadı,Lütfen Doğrulayınız.");
                    //     return View(loginViewModel); 
                    // }

                    await _signInManager.SignOutAsync();
                    var loginResult =
                        await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);

                    if (loginResult.Succeeded)
                    {
                        if (TempData["ReturnUrl"] != null)
                        {
                            return Redirect(TempData["ReturnUrl"].ToString());
                        }

                        return RedirectToAction("Index", "Member", new {area = "Member"});
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Bilgileriniz eksik veya hatalı.");
                }
            }

            return View(loginViewModel);
        }

        public IActionResult PasswordReset()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordReset(ResetPasswordViewModel resetPasswordViewModel)
        {
            // if (resetPasswordViewModel.Email == null) return View();
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
                if (user != null) //Böyle bir E-Mail Adresi Sistem'de  var ise

                {
                    string passwordResetToken =
                        _userManager.GeneratePasswordResetTokenAsync(user).Result; //User bilgilerinden oluşan bir Token
                    string passwordResetLink = Url.Action("PasswordReset", "Home", new
                    {
                        userId = user.Id,
                        token = passwordResetToken
                    }, HttpContext.Request.Scheme);

                    TagHelpers.PasswordResetTagHelper.PasswordResetSendEmail(passwordResetLink, user.Email);
                    ViewBag.Status = "successfull";
                }
            }
            else
            {
                ModelState.AddModelError("", "Sistem'de kayıtlı bir E-Mail adresi yok.");
            }

            return View(resetPasswordViewModel);
        }

        public IActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }
    }
}