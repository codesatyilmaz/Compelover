using AutoMapper;
using Compelover.Business.Notional;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Compelover.WEBUI.Areas.Member.Controllers
{
    [Authorize]
    [Area("Member")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public IActionResult UserList(string searchedUser = null)
        {
            if (!string.IsNullOrEmpty(searchedUser))
            {
                var findUser = _userService.SearchUser(searchedUser);
                return View(findUser);
            }

            var listPeople = _userService.ListOfUsers();
            return View(listPeople);
        }
    }
}