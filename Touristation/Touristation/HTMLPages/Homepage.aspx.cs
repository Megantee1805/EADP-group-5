using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                User user = new User();
                user = user.GetUserById(int.Parse(Session["Id"].ToString())); 
                if (user.isAdmin == false)
                {
                    userPage.Visible = true; 
                }

                else
                {

                }
            }
        }

        protected void LbOwnEntries_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["Id"].ToString());
            Response.Redirect("ViewOwnEntries.aspx?User=" + id); 
        }
    }
}