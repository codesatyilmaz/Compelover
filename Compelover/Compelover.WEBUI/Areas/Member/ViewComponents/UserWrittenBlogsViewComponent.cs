using System.Collections.Generic;
using AutoMapper;
using Compelover.Business.Notional;
using Compelover.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Compelover.WEBUI.Areas.Member.ViewComponents
{
    public class UserWrittenBlogsViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;
        public UserWrittenBlogsViewComponent(IMapper mapper, IBlogService blogService)
        {
            _mapper = mapper;
            _blogService = blogService;
        }

        public ViewViewComponentResult Invoke(string userId)
        {
            var blogUser = _mapper.Map<List<BlogDto>>(_blogService.GetUserBlogCount(userId));
            return View(blogUser);
        }
    }
}