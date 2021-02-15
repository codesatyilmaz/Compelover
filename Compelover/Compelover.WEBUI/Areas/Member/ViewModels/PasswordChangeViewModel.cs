using System.ComponentModel.DataAnnotations;

namespace Compelover.WEBUI.Areas.Member.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Required(ErrorMessage = "Eski Şifreniz Gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifre 4 karekterli olmalı")]
        public string PasswordOld { get; set; }

        [Required(ErrorMessage = "Yeni Şifreniz Gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifre 4 karekterli olmalı")]
        public string PasswordNew { get; set; }

        [Required(ErrorMessage = "Tekrar Yeni Şifreniz Gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(4, ErrorMessage = "Şifre 4 karekterli olmalı")]
        [Compare("PasswordNew",ErrorMessage = "Yeni Şifre ve Onay Şifre birbirinden farklı.")]
        public string PasswordConfirm { get; set; }
    }
}