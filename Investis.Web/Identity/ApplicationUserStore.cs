﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Investis.Web.Identity
{
    public class ApplicationUserStore :UserStore<ApplicationUser>
    {

        public ApplicationUserStore(ApplicationDbContext dbContext):base(dbContext)
        {
                
        }
    }
}