using Investis.DomainModel;
using Investis.DomainModel.GeneratedModels;
//using Investis.Identity;
using Investis.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Investis.Repository.Implementations
{
    public class UsersRepository : IUsers
    {
        InvestisDBEntities db;
        public UsersRepository()
        {
            db = new InvestisDBEntities();
        }
        public void DeleteUser(int userID)
        {

            tb_Users ExisitingUserDetail = db.tb_Users.Where(x => x.UserID == userID).FirstOrDefault();
            if (ExisitingUserDetail != null)
            {
                db.tb_Users.Remove(ExisitingUserDetail);

            }
            db.SaveChanges();
        }

        public string DisableUser(int userID)
        {
            var Response = "Failed";
            tb_Users ExisitingUserDetail = db.tb_Users.Where(x => x.UserID == userID).FirstOrDefault();
            if (ExisitingUserDetail != null)
            {
                ExisitingUserDetail.IsActive = false;
                db.SaveChanges();
                Response = "Success";

                return Response;
            }


            return Response;
        }

        public int GetLatestUserID()
        {
            int lastUserId = db.tb_Users.Select(x => x.UserID).Max();
            return lastUserId;
        }

        public List<tb_Users> GetUserByEmail(string email)
        {
            List<tb_Users> ExisitingUserDetail = db.tb_Users.Where(x => x.Email == email).ToList();
            return ExisitingUserDetail;
        }

        public List<tb_Users> GetUserByEmailAndPassword(string email, string password)
        {
            List<tb_Users> ExisitingUserDetail = db.tb_Users.Where(x => x.Email == email && x.HashPassword == password).ToList();
            return ExisitingUserDetail;
        }

        public List<tb_Users> GetUserByID(int userID)
        {
            List<tb_Users> ExisitingUserDetail = db.tb_Users.Where(x => x.UserID == userID).ToList();
            return ExisitingUserDetail;
        }

        public List<tb_Users> GetUsers()
        {
            List<tb_Users> AllUsers = db.tb_Users.Where(x => x.IsActive == true).OrderBy(x => x.UserID).ToList();
            return AllUsers;
        }

        public void InsertUser(tb_Users  _Users)
        {
            db.tb_Users.Add(_Users);
            db.SaveChanges();

        }

        public void UpdateUserDetail(tb_Users  _Users)
        {
            tb_Users ExisitingUserDetail = db.tb_Users.Where(x => x.UserID == _Users.UserID).FirstOrDefault();
            if (ExisitingUserDetail != null)
            {
                ExisitingUserDetail.FullName = _Users.FullName;
                ExisitingUserDetail.Mobile = _Users.Mobile;
                db.SaveChanges();
            }
        }

        public void UpdateUserPassword(tb_Users  _Users)
        {
            tb_Users ExisitingUserDetail = db.tb_Users.Where(x => x.UserID == _Users.UserID).FirstOrDefault();
            if (ExisitingUserDetail != null)
            {
                ExisitingUserDetail.HashPassword = _Users.HashPassword;

                db.SaveChanges();
            }
        }




    }
}
