using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.ViewModel
{
   public class LoginViewModel
    {

      
        public string Username { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }


    }
}
