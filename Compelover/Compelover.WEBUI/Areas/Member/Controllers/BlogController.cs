using System;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Compelover.Business.Notional;
using Compelover.Entities.DTOs;
using Compelover.Entities.Tangible;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Compelover.WEBUI.Areas.Member.Controllers
{
    [Authorize]
    [Area("Member")]
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBlogService _blogService;
        private readonly UserManager<AppUser> _userManager;

        public BlogController(IMapper mapper, IBlogService blogService, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _blogService = blogService;
            _userManager = userManager;
        }

        public IActionResult BlogList()
        {
            var listBlog = _blogService.ListOfBlog();
            return View(listBlog);
        }

        public IActionResult BlogPostAdd(Blog blog)
        {
            var addedBlogPost = _mapper.Map<BlogDto>(blog);
            return View(addedBlogPost);
        }

        [HttpPost]
        public async Task<IActionResult> BlogPostAdd(BlogDto blogDto, IFormFile blogPicture)
        {
            var blogPost = new Blog();
            if (blogPicture != null && blogPicture.Length > 0)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(blogPicture.FileName);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BlogPicture", fileName);
                //resmi kaydetme.
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await blogPicture.CopyToAsync(stream);
                    blogPost.ImageBlog = "/BlogPicture/" + fileName;
                }
            }

            blogPost.Title = blogDto.Title;
            blogPost.ShortDescription = blogDto.ShortDescription;
            blogPost.Description = blogDto.Description;
            blogPost.AppUserId = blogDto.AppUserId;
            blogPost.PostedTime = blogDto.PostedTime;
            // blogPost.AppUser = blogDto.AppUser;
            _blogService.AddBlogPost(blogPost);
            return RedirectToAction("BlogList");
        }

        public IActionResult BlogContinuation(string blogId)
        {
            var blogDetail = _mapper.Map<BlogDto>(_blogService.GetByBlogId(blogId));
            return View(blogDetail);
        }
    }
}