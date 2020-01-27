using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Touristation.DAL;

namespace Touristation.BLL
{
    public partial class User
    {
        UserDAO userAdapter = new UserDAO();

        public List<User> GetAll(int id)
        {
            UserDAO user = new UserDAO();
            return user.SelectAll(id); 
        }


        public User GetUserByUsername (string name)
        {
            UserDAO user = new UserDAO();
            return user.SelectByUsername(name); 
        }

        public User GetUserById(int id)
        {
            UserDAO user = new UserDAO();
            return user.SelectById(id);
        }

        public void AddUser(User use)
        { 
            UserDAO user = new UserDAO();
            user.Insert(use); 
        }

        public void UpdateProfile(User use)
        {
            UserDAO user = new UserDAO();
            user.Update(use); 
        }

        public void Delete(int id)
        {
            UserDAO user = new UserDAO();
            user.Delete(id); 
        }
    }
}