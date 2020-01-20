using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ViewOwnEntries : System.Web.UI.Page
    {
        List<Entry> eList; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Entry entry = new Entry(); 
            int Id = int.Parse(Request.QueryString["User"]);
            RefreshGridView(Id); 
        }

        private void RefreshGridView(int userId)
        {
            Entry current = new Entry();
            eList = current.GetEntriesByUser(userId); 
            gvViewOwnEntries.Visible = true;
            gvViewOwnEntries.DataSource = eList;
            gvViewOwnEntries.DataBind();

        }

        protected void gvViewOwnEntries_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string commandName = e.CommandName; 
            if (commandName == "View")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewOwnEntries.Rows[Index];
                int entId = int.Parse(gvr.Cells[0].Text);
                Response.Redirect("SingleEntry.aspx?Entry=" + entId);
            }
             
            else if (commandName == "Delete")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewOwnEntries.Rows[Index];
                int entId = int.Parse(gvr.Cells[0].Text);
                Entry entry = new Entry();
                entry.Delete(entId);
                int userId = int.Parse(Session["Id"].ToString());
                Response.Redirect("ViewOwnEntries.aspx?User=" + userId);
            }
        }
    }
}