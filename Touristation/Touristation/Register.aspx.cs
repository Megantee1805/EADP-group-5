using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            else if (tbUsername.Text.Length == 0)
            {
                valid = false;
                errorMsg.Text += "Invalid Username entered" + "<br/>";
            }

            else if (tbPass.Text.Length <= 6)
            {
                valid = false;
                errorMsg.Text += "Password is too short" + "<br/>";
            }

            else if (tbConfirmpass.Text != tbPass.Text)
            {
                valid = false;
                errorMsg.Text += "Passwords do not match" + "<br/>";
            }

            return false; 
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Validate(); 
        }
    }
}