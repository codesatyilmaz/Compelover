using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Compelover.Core.Entities;

namespace Compelover.Entities.Tangible
{
    public class Blog : IEntity
    {
        public Blog()
        {
            AppUsers = new List<AppUser>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BlogId { get; set; }

        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImageBlog { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public string AppUserId { get; set; }
        public List<AppUser> AppUsers { get; set; }

        // public AppUser AppUser { get; set; }
        // public List<Comment> Comments { get; set; }
        // public List<BlogCategory> BlogCategories { get; set; }
        // public List<AppUser> AppUsers { get; set; }
    }
}