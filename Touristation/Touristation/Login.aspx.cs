using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;
using Touristation.DAL;
using System.Web.Helpers;
using System.Drawing;

namespace Touristation
{
    public partial class Login : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User emp = new User();
            User findUser = emp.GetUserByUsername(TbUsername.Text);
            if (findUser != null)
            {
                string hashedPassword = findUser.Password;
                string unhashedPassword = TbPassword.Text; 
                bool hash = Crypto.VerifyHashedPassword(hashedPassword, unhashedPassword); 
                
                if (hash)
                {
                    errorMsg.Text = "Login Successful";
                    errorMsg.ForeColor = Color.Green;
                }

                else
                {
                    errorMsg.Text = "Email or password is wrong";
                    errorMsg.ForeColor = Color.Red;
                     
                }
            }

            else
            {
                errorMsg.Text = "User does not exist";
                errorMsg.ForeColor = Color.Red;
            }
            
        }
    }
}