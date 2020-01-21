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
            com = com.GetCompetitionById(Id);
            tbComName.Text = com.name;
            tbComDesc.Text = com.description;
            ComStart.SelectedDate = com.startDate;
            tbStart.Text = com.startDate.ToShortDateString(); 
            ComEnd.SelectedDate = com.endDate;
            tbEnd.Text = com.endDate.ToShortDateString();
            current = com; 
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
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCompetitions.aspx"); 
        }
    }
}