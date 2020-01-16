using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class UserDAO
    {

        public User SelectByUsername(string name)
        {
            User user;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                user = db.Users.Where(u => u.username == name).FirstOrDefault();
               
            }
            return user; 
        }

        public User SelectById(int id)
        {
            User user;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                user = db.Users.Where(u => u.Id == id).FirstOrDefault();

            }
            return user;
        }

        public User SelectByEmail(string email) {
            User user;

            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                user = db.Users.Where(u => u.email == email).FirstOrDefault();

            }
            return user;
        }

        public void Insert(User use)
        {
            
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                    User user = new User();
                    db.Users.Add(use);
                    db.SaveChanges();
            }
           
        }

        public void Update(User use)
        {
            using (TouristationEntityModel db = new TouristationEntityModel())
            {
                User user = new User();
                User check = db.Users.Where(u => u.Id == use.Id).FirstOrDefault(); 
                if (check != null)
                {
                    check.username = use.username;
                    check.password = use.password;
                    check.email = use.email;
                    check.country = use.country;
                    check.isAdmin = false;
                    check.isBusiness = false; 
                    db.SaveChanges(); 
                }
            }
        }


        /* public int Update(User emp)
        {
            // Execute NonQuery return an integer value
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "Update [User] SET Username = @paraName,Email =@paraEmail, Password=@paraPassword " +
                "where Userid = @paraUserid";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraUserid", emp.Userid);
            sqlCmd.Parameters.AddWithValue("@paraName", emp.Username);
            sqlCmd.Parameters.AddWithValue("@paraEmail", emp.Email);
            sqlCmd.Parameters.AddWithValue("@paraPassword", emp.Password);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        } */
    }
}