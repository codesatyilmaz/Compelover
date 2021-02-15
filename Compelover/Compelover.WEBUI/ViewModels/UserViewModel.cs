using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Compelover.Entities.Tangible;

namespace Compelover.WEBUI.ViewModels
{
    public class UserViewModel : AppUser
    {
       
        // public string Id { get; set; }
        [Required(ErrorMessage = "Lütfen isminizi girin.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadınız")]
        public string SurName { get; set; }

        //Kullanıcının Kayıt olma.
        [Required(ErrorMessage = "Kullanıcı adınız.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Telefon numaranız.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "E-Mail adresiniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string City { get; set; }
        public string Picture { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Gender { get; set; }
        public DateTime? SystemRegistrationDate { get; set; } = DateTime.Now;
        // public Blog Blog { get; set; }
        
        // public List<Blog> Blogs { get; set; }
        // public string BlogId { get; set; }

    }
}