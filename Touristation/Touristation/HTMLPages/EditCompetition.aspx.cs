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
    }
}