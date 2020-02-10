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
    public partial class EditCompetition : System.Web.UI.Page
    {
        Competition current;
        int Id; 

        protected void Page_Load(object sender, EventArgs e)
        {
            Competition com = new Competition();
            Id = int.Parse(Request.QueryString["Competition"]);
            current = com.GetCompetitionById(Id);

            if (IsPostBack == false)
            {
            tbComName.Text = current.name;
            tbComDesc.Text = current.description;
            ComStart.SelectedDate = current.startDate;
            tbStart.Text = current.startDate.ToShortDateString(); 
            ComEnd.SelectedDate = current.endDate;
                tbEnd.Text = current.endDate.ToShortDateString(); 
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

        private bool validation()
        {

            bool result = false;
            LblMsg.Text = String.Empty;

            if (tbComName.Text.Length == 0)
            {
                result = true;
                LblMsg.Text += "Title cannot be empty <br/>";
                LblMsg.ForeColor = Color.Red;
            }

            if (tbComDesc.Text == null)
            {
                result = true;
                LblMsg.Text += "Description cannot be empty <br/>";
                LblMsg.ForeColor = Color.Red;

            }

            if (tbStart.Text.Length == 0)
            {
                result = true;
                LblMsg.Text += "start date cannot be empty <br/>";
                LblMsg.ForeColor = Color.Red;
            }

            else
            {
                if (DateTime.Parse(tbStart.Text.ToString()) <= DateTime.Now)
                {
                    result = true;
                    LblMsg.Text += "start date cannot be in the past <br/>";
                    LblMsg.ForeColor = Color.Red;
                }

                if (DateTime.Parse(tbStart.Text.ToString()) > DateTime.Parse(tbEnd.Text.ToString()))
                {
                    result = true;
                    LblMsg.Text += "start date cannot be later than end date <br/>";
                    LblMsg.ForeColor = Color.Red;
                }

            }

            if (tbEnd.Text.Length == 0)
            {
                result = true;
                LblMsg.Text += "end date cannot be empty <br/>";
                LblMsg.ForeColor = Color.Red;
            }

            else
            {
                if (DateTime.Parse(tbEnd.Text.ToString()) < DateTime.Now)
                {
                    result = true;
                    LblMsg.Text += "end date cannot be in the past <br/>";
                    LblMsg.ForeColor = Color.Red;
                }

                if (DateTime.Parse(tbStart.Text.ToString()) > DateTime.Parse(tbEnd.Text.ToString()))
                {
                    result = true;
                    LblMsg.Text += "start date cannot be later than end date <br/>";
                    LblMsg.ForeColor = Color.Red;
                }

            }

            return result; 
        }


        /* protected void btnEdit_Click(object sender, EventArgs e)
        {
            tbComName.Enabled = true;
            tbComDesc.Enabled = true;
            // tbStart.Enabled = true;
            // tbEnd.Enabled = true;
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnEdit.Visible = false; 
        }

    */

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PickWinners.aspx"); 
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Competition updateComp = new Competition();
            updateComp.Id = Id;
            updateComp.name = tbComName.Text;
            updateComp.description = tbComDesc.Text;
            updateComp.startDate = DateTime.Parse(tbStart.Text);
            updateComp.endDate = DateTime.Parse(tbEnd.Text);
            updateComp.Update(updateComp);
            Response.Redirect("ManageCompetitions.aspx");
        }
    }
}