using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ViewCompetitions : System.Web.UI.Page
    {
        public Competiton chosenCom;
        
        List<Competiton> cList = new List<Competiton>();
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
            if (commandName == "Submit")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index]; 
                int ComId = int.Parse(gvr.Cells[0].Text);
                string Name = gvr.Cells[1].Text; 
                int entNo = int.Parse(gvr.Cells[4].Text);
                Response.Redirect("SubmitEntry.aspx?Competition=" + ComId); 
            }

            else if (commandName == "View")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                string Name = gvr.Cells[1].Text;
                Response.Redirect("ViewEntries.aspx?Competition=" + ComId);
            }
        }

        protected void btnViewEntries_Click(object sender, EventArgs e) {
            int userId = int.Parse(Session["Id"].ToString()); 
            Response.Redirect("ViewEntries.aspx?User=" + userId);
        }




        /* protected void gvViewCompetitions_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (gvViewCompetitions.SelectedIndex >= 0)
             {
                 string ComName = gvViewCompetitions.SelectedRow.Cells[1].Text;
                 int ComId = int.Parse(gvViewCompetitions.SelectedRow.Cells[0].Text);
                 int entNo = int.Parse(gvViewCompetitions.SelectedRow.Cells[4].Text);
                 Session["ComName"] = ComName;
                 Session["ComId"] = ComId;
                 Session["ComEntryNo"] = entNo; 
                 Server.Transfer("SubmitEntry.aspx");
             }
         }

     */
    }

}