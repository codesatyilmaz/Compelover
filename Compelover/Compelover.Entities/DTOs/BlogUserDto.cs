using System.Collections.Generic;
using Compelover.Entities.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.Entities.DTOs
{
    public class BlogUserDto : IDto
    {
        public List<Blog> Blogs { get; set; }
    }
}