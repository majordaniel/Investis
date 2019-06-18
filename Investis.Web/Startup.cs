using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.EntityFramework;
using Investis.Web.Identity;

[assembly: OwinStartup(typeof(Investis.Web.Startup))]

namespace Investis.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            { AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            this.CreateRolesAndUsers();
        }

        public void CreateRolesAndUsers()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var appDbContext = new ApplicationDbContext();
            var appUserStore = new ApplicationUserStore(appDbContext);
            var userManager = new ApplicationUserManager(appUserStore);

            //Create Admin Role
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            //Create Admin User
            if (userManager.FindByName("admin") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";
                string userPassword = "admin123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admin");
                }
            }
            //--------------------------------------------------------------
            //Create Manager Role
            if (!roleManager.RoleExists("Agent"))
            {
                var role = new IdentityRole();
                role.Name = "Agent";
                roleManager.Create(role);
            }

            //Create Manager User
            if (userManager.FindByName("agent") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "agent";
                user.Email = "agent@gmail.com";
                string userPassword = "agent123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Agent");
                }
            }
            //-------------------------------------------------------------------
            //Create Business Owner Role
            if (!roleManager.RoleExists("Business Onwer"))
            {
                var role = new IdentityRole();
                role.Name = "Business Owner";
                roleManager.Create(role);
            }

            //Create Business owner User
            if (userManager.FindByName("business") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "business";
                user.Email = "business@gmail.com";
                string userPassword = "business123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Business Owner");
                }
            }
            //-------------------------------------------------------------------
            //Create Investor Role
            if (!roleManager.RoleExists("Investor"))
            {
                var role = new IdentityRole();
                role.Name = "Investor";
                roleManager.Create(role);
            }

            //Create Business owner User
            if (userManager.FindByName("business") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "investor";
                user.Email = "investor@gmail.com";
                string userPassword = "investor123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Investor");
                }
            }
            //-------------------------------------------------------------------
            //Create Auditor Role
            if (!roleManager.RoleExists("Auditor"))
            {
                var role = new IdentityRole();
                role.Name = "Auditor";
                roleManager.Create(role);
            }

            //Create Business owner User
            if (userManager.FindByName("auditor") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "auditor";
                user.Email = "auditor@gmail.com";
                string userPassword = "auditor123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Auditor");
                }
            }

            //-------------------------------------------------------------------
            //Create accountant Role
            if (!roleManager.RoleExists("Accountant"))
            {
                var role = new IdentityRole();
                role.Name = "Accountant";
                roleManager.Create(role);
            }

            //Create Business owner User
            if (userManager.FindByName("accountant") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "accountant";
                user.Email = "accountant@gmail.com";
                string userPassword = "accountant123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Accountant");
                }
            }

            //-------------------------------------------------------------------
            //Create recoverer Role
            if (!roleManager.RoleExists("Recoverer"))
            {
                var role = new IdentityRole();
                role.Name = "Recoverer";
                roleManager.Create(role);
            }

            //Create recoverer User
            if (userManager.FindByName("recoverer") == null)
            {
                var user = new ApplicationUser();
                user.UserName = "recoverer";
                user.Email = "recoverer@gmail.com";
                string userPassword = "recoverer123";
                var chkUser = userManager.Create(user, userPassword);
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Recoverer");
                }
            }
        }
    }
}



