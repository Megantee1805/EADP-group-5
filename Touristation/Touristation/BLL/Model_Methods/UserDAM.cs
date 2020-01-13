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

        public User GetUserByUsername (string name)
        {
            UserDAO user = new UserDAO();
            return user.SelectByUsername(name); 
        }

        public void AddUser(User use)
        { 
            UserDAO user = new UserDAO();
            user.Insert(use); 
        }
    }
}