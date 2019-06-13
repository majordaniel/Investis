using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.ViewModel
{
    public class NewUsersViewModel
    {
        [Required]
        public int UserID { get; set; }


        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Mobile { get; set; }
        public Nullable<bool> IsActive { get; set; }

    }


    public class NewBusinessViewModel
    {
        [Required]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string Mobile { get; set; }
        public Nullable<bool> IsActive { get; set; }

    }
}
