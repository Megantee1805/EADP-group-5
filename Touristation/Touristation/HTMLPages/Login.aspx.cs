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
        public string user; 
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Touristation.Site1.LoggedIn = false; 
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User emp = new User();
            User findUser = emp.GetUserByUsername(TbUsername.Text);
            if (findUser != null)
            {
                string hashedPassword = findUser.password;
                string unhashedPassword = TbPassword.Text; 
                bool hash = Crypto.VerifyHashedPassword(hashedPassword, unhashedPassword); 
                
                if (hash)
                {

                    errorMsg.Text = "Login Successful";
                    errorMsg.ForeColor = Color.Green;
                    Session["Username"] = TbUsername.Text;
                    Session["Password"] = unhashedPassword;
                    Session["Id"] = findUser.Id; 
                    Touristation.Site1.LoggedIn = true; 
                    Response.Redirect("Homepage.aspx");
                    
                }

                else
                {
                    errorMsg.Text = "Username or password is wrong";
                    errorMsg.ForeColor = Color.Red;
                     
                }
            }

            else
            {
                errorMsg.Text = "Username or password is wrong";
                errorMsg.ForeColor = Color.Red;
            }
            
        }
    }
}