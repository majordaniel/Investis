using Investis.DomainModel.GeneratedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Repository.Interfaces
{
   

    public interface IUsers
    {

        void InsertUser(tb_Users _Users);
        void UpdateUserDetail(tb_Users  _Users);
        void UpdateUserPassword(tb_Users  _Users);
        void DeleteUser(int userID);

        string DisableUser(int userID);
        List<tb_Users> GetUsers();
        List<tb_Users> GetUserByID(int UserID);
        List<tb_Users> GetUserByEmail(string Email);
        List<tb_Users> GetUserByEmailAndPassword(string Email, string Password);

        int GetLatestUserID();
    }
}
