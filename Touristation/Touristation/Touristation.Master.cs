using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL; 

namespace Touristation
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public static bool LoggedIn { get; set; } 
        
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (LoggedIn == true)
            {
                userPanel.Visible = true;
                string user = Session["Username"].ToString();
                Message.Text = "Welcome, " + user; 
                guestPanel.Visible = false;

                if (Session["Username"].ToString() == null)
                {
                    guestPanel.Visible = true;
                    Response.Redirect("Login.aspx");
                }
            }

            else
            {
                guestPanel.Visible = true;
                userPanel.Visible = false; 
            }
        }

        protected void Logout()
        {
            Session.Clear(); 
            Response.Redirect("Login.aspx");
        }
    }
}