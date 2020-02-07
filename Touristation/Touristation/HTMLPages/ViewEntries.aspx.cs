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
            /* User admin = status(); 
            if (admin.isAdmin == true)
            {
                RefreshAdminView(Id, userId); 
            }

            else
            {

            */
                RefreshGridView(Id, userId);
            
            
        }

        /* protected User status()
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

    */

        private void RefreshGridView(int comId, int userId)
        {
            Entry current = new Entry();
            eList = current.GetAllEntriesByOthers(comId, userId);
            foreach (Entry e in eList)
            {
                current.countVotes(e.Id);
            }
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
                Entry upEnt;
                Entry voted = new Entry();
                upEnt = voted.GetEntryById(entId);
                Vote cast = new Vote();
                int userId = int.Parse(Session["Id"].ToString());
                Vote previous = cast.checkPreviousVotes(userId, upEnt.Id);  
                if (previous != null)
                {
                    LblMsg.Text = "You can only vote once"; 
                }
                else
                {
                cast.UserId = userId;
                cast.EntryId = upEnt.Id;
                cast.CastVotes(cast); 
                voted.countVotes(upEnt.Id);
                }
                
                // Response.Redirect("ViewEntries.aspx?Competition=" + ComId);
            }

            /* else if (commandName == "Pick")
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

    */
        }
    }
}