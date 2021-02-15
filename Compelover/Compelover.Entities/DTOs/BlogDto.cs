using System;
using System.Collections.Generic;
using Compelover.Entities.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.Entities.DTOs
{
    public class BlogDto : IDto
    {
        public string BlogId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageBlog { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<AppUser> AppUsers { get; set; }
        
    }
}