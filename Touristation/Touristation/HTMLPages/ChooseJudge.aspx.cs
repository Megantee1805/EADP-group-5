using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ChooseJudge : System.Web.UI.Page
    {
        string userId; 
        protected void Page_Load(object sender, EventArgs e)
        {
            string title = Session["ComTitle"].ToString();
            LblTitle.Text = title;
            string desc = Session["ComDesc"].ToString();
            LblDesc.Text = desc;
            DateTime start = DateTime.Parse(Session["start"].ToString());
            LblStart.Text = start.ToString();
            DateTime end = DateTime.Parse(Session["end"].ToString());
            LblEnd.Text = end.ToString();
            if (IsPostBack == false)
            {
                getPossibleJudges();
                 
            }
            
        }

        private void getPossibleJudges()
        {
            List<User> possibleJudges;
            User use = new User();
            int userId = int.Parse(Session["Id"].ToString());
            possibleJudges = use.GetAll(userId);

            foreach (User judge in possibleJudges)
            {
                ddJudges.DataSource = possibleJudges;
                ddJudges.DataTextField = "username";
                ddJudges.DataValueField = "Id";
                ddJudges.DataBind();
            }


        }

        protected void ddJudges_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblJudge.Text = ddJudges.SelectedItem.ToString();
            userId = ddJudges.SelectedValue; 
        }

        protected void btnComCreate_Click(object sender, EventArgs e)
        {
            Competition com = new Competition();
            com.name = LblJudge.Text;
            com.description = LblDesc.Text;
            com.startDate = DateTime.Parse(LblStart.Text);
            com.JudgingCriteria = "Judges";
            com.judges = int.Parse(ddJudges.SelectedValue.ToString()); 
            com.endDate = DateTime.Parse(LblEnd.Text);
            com.UserId = int.Parse(Session["Id"].ToString());
            com.addCompetition(com);
        }
    }
}