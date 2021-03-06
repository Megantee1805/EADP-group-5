﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Touristation
{
    public partial class all2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void RefreshGridView()
        {

            // using gridview to bind to the list of employee objects
            allcom.Visible = true;
            allcom.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "LIKE")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string key = allcom.DataKeys[index]["Id"].ToString();


                string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);

                conn.Open();
                string sqlstr = "UPDATE comment SET Rate = Rate + 1 WHERE Id = @paraKey";
                SqlCommand sqlcmd = new SqlCommand(sqlstr, conn);
                sqlcmd.Parameters.AddWithValue("@paraKey", key);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                RefreshGridView();
            }

            if (e.CommandName == "DISLIKE")
            {
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string key = allcom.DataKeys[index]["Id"].ToString();

                string connectionstring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionstring);

                conn.Open();
                string sqlstr = "UPDATE comment SET Rate = Rate -1 WHERE Id = @paraKey";
                SqlCommand sqlcmd = new SqlCommand(sqlstr, conn);
                sqlcmd.Parameters.AddWithValue("@paraKey", key);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                RefreshGridView();

            }
        }
    }
}