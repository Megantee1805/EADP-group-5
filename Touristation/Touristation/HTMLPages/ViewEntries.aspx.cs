using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ViewEntries : System.Web.UI.Page
    {
        List<Entry> eList;
        protected void Page_Load(object sender, EventArgs e)
        {
            Competiton com = new Competiton();
            int id; 
            string Id = Request.QueryString["Competition"];
            if (Id == null)
            {
                Id = Request.QueryString["User"];
                id = int.Parse(Id); 
            }

            else
            {
                id = int.Parse(Id); 
                com = com.GetCompetitionById(id);
            }
            
           
            User admin = status(); 
            if (admin.isAdmin == true)
            {
                RefreshAdminView(id); 
            }

            else
            {
                RefreshGridView(id);
            }
            
        }

        protected User status()
        {
            User user = new User();
            int Id = int.Parse(Session["Id"].ToString());
            user = user.GetUserById(Id);
            return user; 
        }

        private void RefreshEntryView(int userId)
        {
            Entry current = new Entry();
            eList = current.GetEntriesByUser(userId);
            gvViewOwnEntries.Visible = true;
            gvViewOwnEntries.DataSource = eList;
            gvViewOwnEntries.DataBind(); 
        }

        private void RefreshAdminView(int comId)
        {
            Entry current = new Entry();
            eList = current.GetEntriesByCompetition(comId);
            gvAdminEntries.Visible = true;
            gvAdminEntries.DataSource = eList;
            gvAdminEntries.DataBind(); 
        }

        private void RefreshGridView(int comId)
        {
            Entry current = new Entry();
            eList = current.GetEntriesByCompetition(comId);
            gvViewEntries.Visible = true;
            gvViewEntries.DataSource = eList;
            gvViewEntries.DataBind();
            
        }

        protected void gvViewEntries_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName == "View")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewEntries.Rows[Index];
                int entId = int.Parse(gvr.Cells[0].Text);
                Response.Redirect("GradeEntry.aspx?Entry=" + entId);
            }
        }
    }
}