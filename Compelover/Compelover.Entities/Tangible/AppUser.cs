using System;
using System.Collections.Generic;
using Compelover.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Compelover.Entities.Tangible
{
    public class AppUser : IdentityUser, IEntity
    {
        public AppUser()
        {
            Blogs = new List<Blog>();
        }

        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Gender { get; set; }
        public DateTime? SystemRegistrationDate { get; set; } = DateTime.Now;
        public List<Blog> Blogs { get; set; }
    }
}