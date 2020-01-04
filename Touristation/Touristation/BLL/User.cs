using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL; 

namespace Touristation.BLL
{
    public class User
    {
        public string Username;
        public string Email; 
        public string Password;
        public User()
        {

        }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password; 
        }

        public int AddUser()
        {
            UserDAO dao = new UserDAO();
            int result = dao.Insert(this);
            return result;
        }

        internal List<User> ToList()
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            UserDAO dao = new UserDAO();
            return dao.SelectAll();
        }

        public User GetUserByUsername(string name)
        {
            UserDAO dao = new UserDAO();
            return dao.SelectByUsername(name);
        }

        public User GetUserByEmail(string email)
        {
            UserDAO dao = new UserDAO();
            return dao.SelectByEmail(email); 
        }
    }

   
}