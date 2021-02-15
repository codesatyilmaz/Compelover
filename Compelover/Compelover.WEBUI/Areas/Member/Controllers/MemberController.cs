using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Compelover.Business.Notional;
using Compelover.Entities.DTOs;
using Compelover.Entities.Tangible;
using Compelover.WEBUI.Areas.Member.ViewModels;
using Compelover.WEBUI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Compelover.WEBUI.Areas.Member.Controllers
{
    [Authorize]
    [Area("Member")]
    public class MemberController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;
        private readonly IUserService _userService;

        public MemberController(UserManager<AppUser> userManager, IMapper mapper, SignInManager<AppUser> signInManager,
            IBlogService blogService, IUserService userService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _blogService = blogService;
            _userService = userService;
        }

        private async Task<UserViewModel> FinByNameUser()
        {
            var findByUserMap = _mapper.Map<UserViewModel>(await _userManager.FindByNameAsync(User.Identity.Name));
            return findByUserMap;
        }


        public async Task<IActionResult> Index()
        {
            var listOfIndex = await FinByNameUser();
            return View(listOfIndex);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserViewModel userViewModel, IFormFile userPicture)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userPicture != null && userPicture.Length > 0)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(userPicture.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserPicture", fileName);
                //resmi kaydetme.
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await userPicture.CopyToAsync(stream);
                    user.Picture = "/UserPicture/" + fileName;
                }
            }

            user.UserName = userViewModel.UserName;
            user.Email = userViewModel.Email;
            user.PhoneNumber = userViewModel.PhoneNumber;
            user.City = userViewModel.City;
            user.BirthDay = userViewModel.BirthDay;
            user.Gender = userViewModel.Gender;
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                //Cooki'yi güncellemek için.
                await _userManager.UpdateSecurityStampAsync(user);
                await _signInManager.SignOutAsync();
                await _signInManager.SignInAsync(user, true);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var itemError in result.Errors)
                {
                    ModelState.AddModelError("", itemError.Description);
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult PasswordChange()
        {
            ViewBag.Member = typeof(UserViewModel);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordChange(PasswordChangeViewModel passwordChange)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name); //Kullanıcıya ulaştık.
                bool exist =
                    await _userManager.CheckPasswordAsync(user,
                        passwordChange.PasswordOld); //eski şifresi doğru mu?çek etmek.
                if (exist) //kullanıcı eski şifreyi doğru girmiş ise(true)
                {
                    IdentityResult result = await _userManager.ChangePasswordAsync(user, passwordChange.PasswordOld,
                        passwordChange.PasswordNew); //şifreyi değiştirdik.
                    if (result.Succeeded)
                    {
                        await _userManager
                            .UpdateSecurityStampAsync(
                                user); //bunu yazmazsak kullanıcı eski şifre ile dolaşmaya devam eder.
                        //Kullanıcıya biz tekrardan çıkış ve giriş işlemi yaptırdık kullanıcı bunu anlayamacak ve cooki'si tekrar oluşacak.
                        await _signInManager.SignOutAsync();
                        //yeni şifre ile yeniden giriş yaptırdık.
                        await _signInManager.PasswordSignInAsync(user, passwordChange.PasswordNew, true, false);
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Eski Şifre Hatalı.");
                }
            }

            return View(passwordChange);
        }

        public IActionResult UserProfile(string userId)
        {
            var userArea = _mapper.Map<UserListDto>(_userService.GetByUserId(userId));
            return View(userArea);
            // var userArea = _userManager.FindByNameAsync(User.Identity.Name).Result;
            // return View(userArea);
        }

        public IActionResult BlogUser(string userId)
        {
            var blogUser = _mapper.Map<List<BlogDto>>(_blogService.GetUserBlogCount(userId));
            return View(blogUser);
            // var blogUser = _blogService.GetUserBlogCount(userId);
            // return View(blogUser);
        }
    }
}