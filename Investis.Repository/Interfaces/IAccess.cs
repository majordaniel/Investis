using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Repository.Interfaces
{
    public interface IAccess
    {

        bool CheckUserExistence(string Email);

        object Login(string Email, string Password);
    } 
}
