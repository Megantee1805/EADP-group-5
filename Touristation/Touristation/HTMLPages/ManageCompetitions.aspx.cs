using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class AdminCompetitions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView(); 
        }

        private void RefreshGridView()
        {
            Competition current = new Competition();
            List<Competition> cList = current.SelectAll();
            foreach (Competition c in cList)
            {
                current.countEntries(c);
            }

            gvViewCompetitions.Visible = true;
            gvViewCompetitions.DataSource = cList;
            gvViewCompetitions.DataBind();
        }

        protected void gvViewCompetitions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName == "Edit")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                string Name = gvr.Cells[1].Text;
                int entNo = int.Parse(gvr.Cells[5].Text);
                Response.Redirect("EditCompetition.aspx?Competition=" + ComId);
            }

            else if (commandName == "Delete")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                Competition com = new Competition();
                com.Delete(ComId);
                Response.Redirect("ManageCompetitions.aspx"); 
            }
        }
    }
}