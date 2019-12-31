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

        string errorMsg; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            bool valid = true; 
            if (tbEmail.Text.Contains("@") == false)
            {
                valid = false; 
            }

            else if (tbUsername.Text.Length == 0)
            {
                valid = false; 
            }

            else if (tbPass.Text.Length <= 6)
            {
                valid = false; 
            }

            else if (tbConfirmpass.Text != tbPass.Text)
            {
                valid = false; 
            }

            return false; 
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}