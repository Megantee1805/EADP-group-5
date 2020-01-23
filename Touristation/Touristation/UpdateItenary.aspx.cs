using Itenary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itenary
{
    public partial class UpdateItenary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                NOPTB.Text = (string)Session["SSName"];
                TbTime.Text = (string)Session["SSTime"];
                TbDate.Text = (string)Session["SSDate"];
                TBLocation.Text = (string)Session["SSLocation"];

            }
        }



        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewItenary.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                DateTime doe = Convert.ToDateTime(TbDate.Text);


                ItenaryX itn = new ItenaryX(NOPTB.Text, TbTime.Text, doe, TBLocation.Text);
                int result = itn.UpdateItenary();
                if (result == 1)
                {
                    LblMsg.Text = "Record updated successfully!";

                }
                else
                {
                    LblMsg.Text = "Error in adding record! Inform System Administrator!";

                }
            }
        }
        private bool ValidateInput()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (NOPTB.Text == "")
            {
                LblMsg.Text += "Name of place is required!" + "<br/>";
            }
            if (TbTime.Text == "")
            {
                LblMsg.Text += "Time is required!" + "<br/>";
            }
            DateTime doe;
            result = DateTime.TryParse(TbDate.Text, out doe);
            if (!result)
            {
                LblMsg.Text += "Event date is invalid!" + "<br/>";
            }
            if (TBLocation.Text == "")
            {
                LblMsg.Text += "Location is required!" + "<br/>";
            }

            if (String.IsNullOrEmpty(LblMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
