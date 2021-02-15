using System;
using System.Collections.Generic;
using Compelover.Entities.Notional;
using Compelover.Entities.Tangible;

namespace Compelover.Entities.DTOs
{
    public class UserListDto:IDto
    {
       
        // public string Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string City { get; set; }
        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Gender { get; set; }
        public DateTime? SystemRegistrationDate { get; set; } = DateTime.Now;
        
        public Blog Blog { get; set; }
        
        public string BlogId { get; set; }
    }
}