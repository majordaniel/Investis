using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.ViewModel
{
    public class BusinessRegisterViewModel
    {

        [Required(ErrorMessage = "Username can't be blank")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password can't be blank")]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile can't be blank")]
        public string Mobile { get; set; }

       [Required(ErrorMessage = "Business Name can't be blank")]
        public string BusinessName { get; set; }

        [Required(ErrorMessage = "Address can't be blank")]
        public string Address { get; set; }


        [Required(ErrorMessage = "City can't be blank")]
        public string City { get; set; }


        [Required(ErrorMessage = "Country can't be blank")]
        public string CountryID { get; set; }
    }
}
