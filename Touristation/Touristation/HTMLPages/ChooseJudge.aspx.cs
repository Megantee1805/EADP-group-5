using System;
using System.Collections.Generic;
using System.IO;
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
        DateTime start;
        DateTime end;
        protected void Page_Load(object sender, EventArgs e)
        {
            string title = Session["ComTitle"].ToString() + imageLink;
            LblTitle.Text = title;
            string desc = Session["ComDesc"].ToString();
            LblDesc.Text = desc;
            start = DateTime.Parse(Session["start"].ToString());
            LblStart.Text = start.ToString("MM/dd/yyyy");
            end = DateTime.Parse(Session["end"].ToString());
            LblEnd.Text = end.ToString("MM/dd/yyyy");  
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

        /* protected void ddJudges_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblJudge.Text = ddJudges.SelectedItem.ToString();
            userId = ddJudges.SelectedValue; 
        }

    */

        protected void btnComCreate_Click(object sender, EventArgs e)
        {
            Competition com = new Competition();
            com.name = LblTitle.Text;
            com.description = LblDesc.Text;
            com.startDate = start;
            string filename = Path.GetFileName(prizeLink.FileName);
            string filePath = "~/Images" + filename;
            prizeLink.SaveAs(Server.MapPath(filePath));
            com.prize = filePath; 
            com.JudgingCriteria = "Judges";
            com.judges = int.Parse(ddJudges.SelectedValue.ToString()); 
            com.endDate = end;
            com.UserId = int.Parse(Session["Id"].ToString());
            com.addCompetition(com);
            LblMsg.Text = "Successfully created"; 
        }
    }
}