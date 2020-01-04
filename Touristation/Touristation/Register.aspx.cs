using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;
using System.Web.Helpers;
using System.Drawing;

namespace Touristation
{
    public partial class Resgiter : System.Web.UI.Page

    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            bool valid = true;
            errorMsg.Text = String.Empty; 

            if (tbEmail.Text.Contains("@") == false)
            {
                valid = false;
                errorMsg.Text += "Invalid Email entered" + "<br/>"; 
            }

            if (tbUsername.Text.Length == 0)
            {                valid = false;
                errorMsg.Text += "Invalid Username entered" + "<br/>";
            }

            if (tbPass.Text.Length <= 6)
            {
                valid = false;
                errorMsg.Text += "Password is too short" + "<br/>";
            }

            if (tbConfirm.Text != tbPass.Text)
            {
                valid = false;
                errorMsg.Text += "Passwords do not match" + "<br/>";
            }

            errorMsg.ForeColor = Color.Red; 
            return valid; 
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            User emp = new User();
            string pass = tbPass.Text;
            string hash = Crypto.HashPassword(pass); 

            if (emp.GetUserByUsername(tbUsername.Text) != null)
            {
                errorMsg.Text = "User is already registered";
                errorMsg.ForeColor = Color.Red;
            }

            else
            {
                if (validate())
                   {
                    emp = new User(tbUsername.Text, tbEmail.Text, hash);
                    int result = emp.AddUser(); 
                    if (result == 1)
                    {
                        errorMsg.Text = "Registration is successful";
                        errorMsg.ForeColor = Color.Green; 
                    }

                    else
                    {
                        errorMsg.Text = "There is an issue with registering you, please ask system administrator";
                        errorMsg.ForeColor = Color.Red; 
                    }
                   }
            }

         


        }


    }
}