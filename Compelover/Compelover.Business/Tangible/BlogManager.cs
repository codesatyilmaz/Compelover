using System.Collections.Generic;
using System.Linq;
using Compelover.Business.Notional;
using Compelover.DataAccess.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.Business.Tangible
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> ListOfBlog()
        {
            return _blogDal.GetAll().OrderByDescending(b => b.BlogId).ToList();
        }

        public Blog GetByBlogId(string blogId)
        {
            return _blogDal.Get(b => b.BlogId == blogId);
        }

        public void AddBlogPost(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public List<Blog> GetUserBlogCount(string userId)
        {
            return _blogDal.GetUserBlogCount(userId);
        }

        
    }
}