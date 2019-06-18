using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Web.Identity
{
   public class ApplicationUser : IdentityUser
    {

        public int DivisionID { get; set; }
        public int BranchID { get; set; }
        public int DeptID { get; set; }

        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CountryID { get; set; }
    }
}
