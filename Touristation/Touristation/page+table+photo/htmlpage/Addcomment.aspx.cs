using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Touristation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Commentpage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            {
                
                string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);
                
                conn.Open();
                string sqlstr = "Insert into comment(Id, Loca, Rate, Com) Values((SELECT ISNULL(MAX(ID) + 1, 1) FROM comment), @Loca, @Rate, @com)";
                SqlCommand sqlcmd = new SqlCommand(sqlstr, conn);
                sqlcmd.Parameters.AddWithValue("@Loca", "zoo");
                sqlcmd.Parameters.AddWithValue("@Rate", 0);
                sqlcmd.Parameters.AddWithValue("@com", comen.Text);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                comen.Text = "";
                comen.Text = string.Empty;
            }
        }
    }
}