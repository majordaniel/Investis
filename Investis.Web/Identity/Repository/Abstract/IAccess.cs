using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Web.Identity.Repository.Abstract
{
    public interface IAccess
    {

        bool CheckUserExistence(string Email);

        object Login(string Email, string Password);
    } 
}
