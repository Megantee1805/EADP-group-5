using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class CreateCompetition : System.Web.UI.Page
    {
        List<Competition> cList;
        string value; 
        public static string prizes { get; set; }
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
                Session["ComTitle"] = tbTitle.Text;
                Session["ComDesc"] = tbComDesc.Text;
                Session["start"] = tbStart.Text;
                Session["end"] = tbEnd.Text;
                Session["method"] = "Votes"; 
                Response.Redirect("PickPrize.aspx");
            }
        }
        
       

        private bool validate()
        {
            bool result = false;
            LblMsg.Text = String.Empty; 

            if (tbTitle.Text.Length == 0)
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


            if (rgroupJudgingMethod.SelectedIndex == -1)
            {
                result = true;
                LblMsg.Text += "judging method must be selected";
                LblMsg.ForeColor = Color.Red;
            }

            
            return result; 
        }

        protected void rgroupJudgingMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = int.Parse(rgroupJudgingMethod.SelectedValue);
            if (value == 1)
            {
                btnComCreate.Visible = false;
                btnChooseNext.Visible = true;
            }

            else
            {
                btnComCreate.Visible = true;
                btnChooseNext.Visible = false;
            }
            
        }

        protected void btnChooseNext_Click(object sender, EventArgs e)
        {
            bool result = validate();
            if (result == false)
            {
                Session["ComTitle"] = tbTitle.Text;
                Session["ComDesc"] = tbComDesc.Text;
                Session["start"] = tbStart.Text;
                Session["end"] = tbEnd.Text;
                Response.Redirect("ChooseJudge.aspx"); 

            }
        }
    } 
}