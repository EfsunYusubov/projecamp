using System.ComponentModel.DataAnnotations;

namespace ProjectCamp.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Role girin")]
        public string name { get; set; }
    }
}
