using System.Collections.Generic;
using AutoMapper;
using Compelover.Business.Notional;
using Compelover.WEBUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Compelover.WEBUI.Areas.Member.ViewComponents
{
    public class UserListViewComponent:ViewComponent
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public UserListViewComponent(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public ViewViewComponentResult Invoke()
        {
            var peopleList = _mapper.Map<List<UserViewModel>>(_userService.ForComponentUsersList());
            return View(peopleList);
        }
    }
}