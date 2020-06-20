using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace digiestate.Web.Models
{
    public class RegisterModel
    {
        [DisplayName("Name")]
        [Required]
        public string FullName { get; set; }

        [DisplayName("Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confrim Password")]
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}