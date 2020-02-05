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

            /* if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

    */ 


            if (LoggedIn == true)
            {
                
                userPanel.Visible = true;
                string user = Session["Username"].ToString();
                string Id = Session["Id"].ToString();
                int userId = int.Parse(Id); 
                Message.Text = "Welcome, " + user; 
                guestPanel.Visible = false;
                User search = new User();
                User admin = search.GetUserById(userId);
                bool? status = admin.isAdmin; 

                if (Session["Username"].ToString() == null)
                {
                    guestPanel.Visible = true;
                    Response.Redirect("Login.aspx");
                }

                if (status == true)
                {
                    adminPanel.Visible = true;
                    userPanel.Visible = false; 
                    
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