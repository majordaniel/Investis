using Investis.DomainModel;
using Investis.DomainModel.GeneratedModels;
using Investis.Helpers.EncryptionEngine;
//using Investis.Helpers.EncryptionEngine;
//using Investis.Identity;
//using Investis.Repository.Interfaces;
using Investis.Web.Identity.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Web.Identity.Repository.Implementations
{


    internal class LoginResponse
    {
        public int UserId { get; set; }
        public string LoginResult { get; set; }
    }
    public class AccessRepository: IAccess
    {

        InvestisDBEntities db;
        public AccessRepository()
        {
            var db = new ApplicationDbContext();
        }
        public bool CheckUserExistence(string Email)
        {
            bool IsExist = false;
            UsersRepository UsersDetail = new UsersRepository();

            var User = UsersDetail.GetUserByEmail(Email);

            if (User != null)
            {
                IsExist = true;
            }

            return IsExist;
        }

        public object Login(string email, string password)
        {
            Encryption Enc = new Encryption();

            var CheckedEncString = Enc.EnCrypt(password);



            tb_Users ExisitingUserDetail = db.tb_Users.Where(x => x.Email == email || x.HashPassword == CheckedEncString).SingleOrDefault();

            var Resp = new LoginResponse
            {
                UserId = 3,
                LoginResult = "Success"

            };


            return Resp;
        }
    }

}
