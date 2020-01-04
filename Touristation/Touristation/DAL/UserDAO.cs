using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Touristation.BLL; 

namespace Touristation.DAL
{
    public class UserDAO
    {
        public List<User> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<User> empList = new List<User>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string name = row["Username"].ToString();
                string email = row["Email"].ToString();
                string pass= row["password"].ToString();
                User obj = new User(name, email, pass); 
                empList.Add(obj);
            }

            return empList;
        }

        public User SelectByUsername(string name)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from [User] where username = @paraUsername";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraUsername", name);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            User emp = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string uname = row["Username"].ToString();
                string email = row["Email"].ToString();
                string pass = row["password"].ToString();
                emp = new User(uname, email, pass);
            }
            else
            {
                emp = null;
            }

            return emp;
        }

        public User SelectByEmail(string email)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from User where Email = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            User emp = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string uname = row["Username"].ToString();
                string mail = row["Email"].ToString();
                string pass = row["password"].ToString();
                emp = new User(uname, mail, pass);
            }
            else
            {
                emp = null;
            }

            return emp;
        }

        public int Insert(User emp)
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
            string sqlStmt = "INSERT INTO [User] (Username, Email, Password) " +
                "VALUES (@paraName, @paraEmail, @paraPassword)";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraName", emp.Username);
            sqlCmd.Parameters.AddWithValue("@paraEmail", emp.Email);
            sqlCmd.Parameters.AddWithValue("@paraPassword", emp.Password);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
    }
}