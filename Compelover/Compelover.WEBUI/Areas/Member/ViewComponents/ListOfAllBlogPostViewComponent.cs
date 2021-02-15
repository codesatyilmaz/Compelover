using Compelover.Business.Notional;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Compelover.WEBUI.Areas.Member.ViewComponents
{
    public class ListOfAllBlogPostViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;

        public ListOfAllBlogPostViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public ViewViewComponentResult Invoke()
        {
            var listOfAllBlog = _blogService.ListOfBlog();
            return View(listOfAllBlog);
        }
    }
}