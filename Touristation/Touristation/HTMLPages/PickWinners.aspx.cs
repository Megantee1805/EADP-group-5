using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class PickWinners : System.Web.UI.Page
    {
        List<Competiton> cList; 
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView(); 
        }

        private void RefreshGridView()
        {
            Competiton current = new Competiton();
            cList = current.SelectAvailableCompetitions();
            foreach (Competiton c in cList)
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
            /* if (commandName == "View")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                string Name = gvr.Cells[1].Text;
                Response.Redirect("ViewEntries.aspx?Competition=" + ComId);
            }

    */

            if (commandName == "Edit")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                Response.Redirect("EditCompetition.aspx?Com=" + ComId); 
            }

            else if (commandName == "Delete")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                Competiton com = new Competiton();
                com.Delete(ComId);
                Response.Redirect("PickWinners.aspx"); 

            }
        }
    }
}