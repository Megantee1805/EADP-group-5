using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class CreateCompetition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (IsPostBack)
            {

            }
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

        protected void btnComCreate_Click(object sender, EventArgs e)
        {
            bool result = validate(); 
            if (result == false)
            {
                LblMsg.Text += "Successfully Created";
                LblMsg.ForeColor = Color.Green;
                Competition com = new Competition();
                com. = tbTitle.Text;
                com.description = tbComDesc.Text;
                com.startDate = DateTime.Parse(tbStart.Text);
                com.endDate = DateTime.Parse(tbEnd.Text);
                com.UserId = int.Parse(Session["Id"].ToString());
                com.addCompetition(com); 
            }
        }

        private bool validate()
        {
            bool result = false;
            LblMsg.Text = String.Empty; 

            if (tbTitle.Text.Length == 0)
            {
                LblMsg.Text += "Title cannot be empty";
                LblMsg.ForeColor = Color.Red; 
            }

            if (tbComDesc.Text == null)
            {
                LblMsg.Text += "Description cannot be empty";
                LblMsg.ForeColor = Color.Red; 

            }

            if (DateTime.Parse(tbStart.Text.ToString()) < DateTime.Now)
            {
                LblMsg.Text += "start date cannot be in the past";
                LblMsg.ForeColor = Color.Red;
            }

            if (DateTime.Parse(tbEnd.Text.ToString()) < DateTime.Now)
            {
                LblMsg.Text += "end date cannot be in the past";
                LblMsg.ForeColor = Color.Red;
            }

            return result; 
        }
    }
}