using Investis.Services.HelperServices;
using Investis.ViewModel;
using Investis.Web.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Investis.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {

            DropDownListsData ddlists = new DropDownListsData();
            //ViewBag.VCountryList = new SelectList(Countries, "CountryID", "CountryName");

            ViewBag.VCountryList = ddlists.CountryListDropDown();
            return View();
        }


        [HttpPost]
        public ActionResult Register(BusinessRegisterViewModel rvm)
        {

            if (ModelState.IsValid)
            {
                //register
                var appDbContext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbContext);
                var userManager = new ApplicationUserManager(userStore);
                var passwordHash = Crypto.HashPassword(rvm.Password);
                var user = new ApplicationUser()
                {
                    Email = rvm.Email,
                    UserName = rvm.Username,
                    PasswordHash = passwordHash,
                    BusinessName = rvm.BusinessName,
                    City = rvm.City,
                    CountryID = rvm.CountryID,
                    Address = rvm.Address,
                    PhoneNumber = rvm.Mobile
                };
                IdentityResult result = userManager.Create(user);

                if (result.Succeeded)
                {
                    //role
                    userManager.AddToRole(user.Id, "Business Owner");

                    //login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("My Error", "Invalid data");
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(LoginViewModel lvm)
        {
            if (lvm.Username !=null || lvm.Password !=null)
            {
              

                //login
                var appDbContext = new ApplicationDbContext();
                var userStore = new ApplicationUserStore(appDbContext);
                var userManager = new ApplicationUserManager(userStore);
                var user = userManager.Find(lvm.Username, lvm.Password);
                if (user != null)
                {
                    //login
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);

                    if (userManager.IsInRole(user.Id, "Admin"))
                    {
                        // return RedirectToAction("Index", "Home", new { area = "Admin" });
                        return RedirectToAction("Index", "Home");

                    }
                    else if (userManager.IsInRole(user.Id, "Manager"))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("myerror", "Invalid username or password");
                   
                }
                
            }
            else
            {
                ModelState.AddModelError("myerror", "Username or Password must not be empty");
            }

            return View();
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            return RedirectToAction("Login", "Account");
        }

        // GET: Account/MyProfile
        public ActionResult MyProfile()
        {
            var appDbContext = new ApplicationDbContext();
            var userStore = new ApplicationUserStore(appDbContext);
            var userManager = new ApplicationUserManager(userStore);
            ApplicationUser appUser = userManager.FindById(User.Identity.GetUserId());
            return View(appUser);
        }

    }
}