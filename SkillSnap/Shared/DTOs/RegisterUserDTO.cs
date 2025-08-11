using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkillSnap.Shared.DTOs
{
    public class RegisterUserDTO
    {
        [Required(ErrorMessage = "This field is required.")]
        public string FirstInitial { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
