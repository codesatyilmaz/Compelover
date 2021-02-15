using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Compelover.Entities.Tangible;

namespace Compelover.WEBUI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-Mail adresinizi girmelisiniz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifreniz?")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifreniz 4 karekterli olmalıdır")]
        public string Password { get; set; }

        public List<Blog> Blogs { get; set; }

        // public List<UserViewModel> UserViewModels { get; set; }
    }
}