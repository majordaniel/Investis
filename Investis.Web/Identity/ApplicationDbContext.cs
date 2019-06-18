
using Investis.Web.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investis.Web.Identity
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext():base("DefaultConnection")
        {

        }

    }
}