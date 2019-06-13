
using Investis.DomainModel.GeneratedModels;
using Investis.Helpers.EncryptionEngine;
using Investis.Repository.Implementations;
using Investis.Repository.Interfaces;
using Investis.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investis.Services
{
    public interface IUserService
    {
        void InsertUser(NewUsersViewModel _Users);
        void UpdateUserDetail(NewUsersViewModel _Users);
        void UpdateUserPassword(NewUsersViewModel _Users);
        void DeleteUser(int userID);
        string DisableUser(int userID);
        List<NewUsersViewModel> GetUsers();
        NewUsersViewModel GetUserByID(int UserID);
        List<NewUsersViewModel> GetUserByEmail(string Email);
        List<NewUsersViewModel> GetUserByEmailAndPassword(string Email, string Password);
        int GetLatestUserID();
    }
    public class UsersService : IUserService
    {

        IUsers _userRepository;
        public UsersService()
        {
            _userRepository = new UsersRepository();
        }
        public void DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        public string DisableUser(int userID)
        {
            string status = "failed";
            tb_Users ExistingUser = _userRepository.GetUserByID(userID).FirstOrDefault();
            if (ExistingUser != null)
            {
                tb_Users UserToDisable = new tb_Users
                {
                    UserID = userID,
                    IsActive = false
                };
                _userRepository.UpdateUserDetail(UserToDisable);
                status = "success";
            }

            return status;

        }

        public int GetLatestUserID()
        {
            throw new NotImplementedException();
        }

        public List<NewUsersViewModel> GetUserByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public List<NewUsersViewModel> GetUserByEmailAndPassword(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public NewUsersViewModel GetUserByID(int UserID)
        {

            tb_Users ExistingUser = _userRepository.GetUserByID(UserID).FirstOrDefault();
            NewUsersViewModel GottenUser = null;
                if (ExistingUser !=null)
            {
                 GottenUser = new NewUsersViewModel
                {
                    Email = ExistingUser.Email,

                };
            }
            return GottenUser;
        }

        public List<NewUsersViewModel> GetUsers()
        {
            List<NewUsersViewModel> Users = null;
         
            return Users;
        }

        public void InsertUser(NewUsersViewModel _Users)
        {
            

            Encryption encryption = new Encryption();

            tb_Users newUser = new tb_Users
            {
                Email = _Users.Email,
                FullName = _Users.FullName,
                HashPassword = encryption.EnCrypt(_Users.HashPassword),
            };
            _userRepository.InsertUser(newUser);
        }

        public void UpdateUserDetail(NewUsersViewModel _Users)
        {
            tb_Users ExistingUser = _userRepository.GetUserByID(_Users.UserID).FirstOrDefault();
            if (ExistingUser != null)
            {
                tb_Users UserToUpdate = new tb_Users
                {
                    Email = _Users.Email,
                };
                _userRepository.UpdateUserDetail(UserToUpdate);
            }
           
        }

        public void UpdateUserPassword(NewUsersViewModel _Users)
        {
            tb_Users ExistingUser = _userRepository.GetUserByID(_Users.UserID).FirstOrDefault();
            if (ExistingUser != null)
            {
                tb_Users UserToUpdate = new tb_Users
                {
                     HashPassword = _Users.HashPassword,
                };
                _userRepository.UpdateUserDetail(UserToUpdate);
            }
        }
    }
}
