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
        int count;
        int Id;
        int ComId;
        int entryId; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Competition com = new Competition();
            Id = int.Parse(Request.QueryString["Competition"]);
            com = com.GetCompetitionById(Id);
            ComId = Id;
            int userId = int.Parse(Session["Id"].ToString()); 
            User admin = status(); 
            if (admin.isAdmin == true)
            {
                RefreshAdminView(Id, userId); 
            }

            else
            {
                RefreshGridView(Id, userId);
            }
            
        }

        protected User status()
        {
            User user = new User();
            int Id = int.Parse(Session["Id"].ToString());
            user = user.GetUserById(Id);
            return user; 
        }

        private void RefreshAdminView(int comId, int userId)
        {
            Entry current = new Entry();
            eList = current.GetAllEntriesByOthers(comId, userId);
            gvAdminEntries.Visible = true;
            gvAdminEntries.DataSource = eList;
            gvAdminEntries.DataBind(); 
        }

        private void RefreshGridView(int comId, int userId)
        {
            Entry current = new Entry();
            eList = current.GetAllEntriesByOthers(comId, userId);
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
                count += 1;
                Entry upEnt;
                Entry voted = new Entry();
                upEnt = voted.GetEntryById(entId);
                upEnt.votes = count;
                voted.CountVotes(upEnt);
                Response.Redirect("ViewEntries.aspx?Competition=" + ComId);
            }

            else if (commandName == "Pick")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvAdminEntries.Rows[Index];
                int entId = int.Parse(gvr.Cells[0].Text);
                Entry winner;
                Entry ent = new Entry();
                winner = ent.GetEntryById(entId);
                winner.rank = 1;
                ent.Update(winner); 
            }
        }
    }
}