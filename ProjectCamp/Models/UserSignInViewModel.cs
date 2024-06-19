using System.ComponentModel.DataAnnotations;

namespace ProjectCamp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="İstifadəçi adı girin")]
        public string username { get; set; }


        [Required(ErrorMessage = "Şifrə girin")]
        public string password { get; set; }

    }
}
