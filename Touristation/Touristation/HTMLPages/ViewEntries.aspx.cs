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
        protected void Page_Load(object sender, EventArgs e)
        {
            Competiton com = new Competiton();
            int Id = int.Parse(Request.QueryString["Competition"]);
            com = com.GetCompetitionById(Id);
            ComId = Id; 
            User admin = status(); 
            if (admin.isAdmin == true)
            {
                RefreshAdminView(Id); 
            }

            else
            {
                RefreshGridView(Id);
            }
            
        }

        protected User status()
        {
            User user = new User();
            int Id = int.Parse(Session["Id"].ToString());
            user = user.GetUserById(Id);
            return user; 
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
                count += 1;
                Entry upEnt;
                Entry voted = new Entry();
                upEnt = voted.GetEntryById(Id);
                upEnt.votes = count;
                voted.CountVotes(upEnt);
                Response.Redirect("ViewEntries.aspx?Competition=" + ComId);
            }
        }
    }
}