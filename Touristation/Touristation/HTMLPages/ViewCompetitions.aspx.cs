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
        int Id;

        public Competition chosenCom;
        
        List<Competition> cList = new List<Competition>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Session["Id"].ToString()); 
            RefreshGridView(Id);
            RefreshJudge(Id); 
            showEndedCompetitions(); 

        }

        private void showEndedCompetitions()
        {
            Competition current = new Competition();
            cList = current.SelectEndedCompetitions();
            foreach (Competition c in cList)
            {
                current.countEntries(c);
                current.UpdateRank(c); 
                current.SelectWinner(c.Id); 
            }
            gvEndedCompetitions.Visible = true;
            gvEndedCompetitions.DataSource = cList;
            gvEndedCompetitions.DataBind();
        }

        private void RefreshGridView(int user)
        {
            Competition current = new Competition();
            cList = current.SelectAvailableCompetitions(user);
            foreach (Competition c in cList)
            {
                current.countEntries(c);
            }

            gvViewCompetitions.Visible = true;
            gvViewCompetitions.DataSource = cList;
            gvViewCompetitions.DataBind();
        }

        private void RefreshJudge(int userId)
        {
            Competition current = new Competition(); 
            cList = current.SelectJudgingCompetitions(userId);
            foreach (Competition c in cList)
            {
                current.countEntries(c);
            }
            gvJudge.Visible = true;
            gvJudge.DataSource = cList;
            gvJudge.DataBind();
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
            Response.Redirect("ViewOwnEntries.aspx?User=" + userId);
        }

        protected void gvEndedCompetitions_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string commandName = e.CommandName; 
            if (commandName == "View")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvEndedCompetitions.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                string Name = gvr.Cells[1].Text;
                Response.Redirect("EndedEntry.aspx?Competition=" + ComId);
            }
        }
           

        protected void gvJudge_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            string commandName = e.CommandName;
            if (commandName == "View")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvJudge.Rows[Index];
                int ComId = int.Parse(gvr.Cells[0].Text);
                Response.Redirect("JudgeEntry.aspx?Judge=" + ComId);
            }
            
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