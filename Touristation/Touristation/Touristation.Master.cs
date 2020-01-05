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
                guestPanel.Visible = false;
            }

            else
            {
                guestPanel.Visible = true;
                userPanel.Visible = false; 
            }
        }

        private void checkUser()
        {
             
        }
    }
}