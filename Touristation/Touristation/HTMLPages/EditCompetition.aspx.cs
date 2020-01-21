using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class EditCompetition : System.Web.UI.Page
    {
        Competiton current;

        protected void Page_Load(object sender, EventArgs e)
        {
            Competiton com = new Competiton();
            int Id = int.Parse(Request.QueryString["Competition"]);
            current = com.GetCompetitionById(Id);
            tbComName.Text = current.name;
            tbComDesc.Text = current.description;
            ComStart.SelectedDate = current.startDate;
            tbStart.Text = current.startDate.ToShortDateString(); 
            ComEnd.SelectedDate = current.endDate;
            tbEnd.Text = current.endDate.ToShortDateString();
        }

        protected void ComStart_SelectionChanged(object sender, EventArgs e)
        {

            tbStart_PopupControlExtender.Commit(ComStart.SelectedDate.ToShortDateString());
            UpdateCalender.Update();
        }

        protected void ComEnd_SelectionChanged(object sender, EventArgs e)
        {
            tbEnd_PopupControlExtender.Commit(ComEnd.SelectedDate.ToShortDateString());
            UpdateCalender.Update();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Competiton com = new Competiton();
            current.name = tbComName.Text;
            current.description = tbComDesc.Text;
            current.startDate = DateTime.Parse(tbStart.Text);
            current.endDate = DateTime.Parse(tbEnd.Text);
            com.Update(current);
            Response.Redirect("PickWinners.aspx"); 
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCompetitions.aspx"); 
        }
    }
}