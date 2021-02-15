using System.ComponentModel.DataAnnotations;

namespace Compelover.WEBUI.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Unutmanız'a üzüldük,E-Mail adresiniz bizim için çok önemli demiştik.")]
        public string Email { get; set; }
    }
}