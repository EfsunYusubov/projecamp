using System.ComponentModel.DataAnnotations;

namespace ProjectCamp.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage = "Doldurun")]
        public string nameSurname { get; set; }

        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Xahiş olunur şifrə girin")]
        public string Password { get; set; }

        [Display(Name = "Şifrə təkrar")]
        [Compare("Password", ErrorMessage = "Şifrələr uyğun deyil")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail adresi")]
        [Required(ErrorMessage = "Doldurun")]
        public string Mail { get; set; }

        [Display(Name = "İstifadəçi adı")]
        [Required(ErrorMessage = "Doldurun")]
        public string UserName { get; set; }
    }
}
