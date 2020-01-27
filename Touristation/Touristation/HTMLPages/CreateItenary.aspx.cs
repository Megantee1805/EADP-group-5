using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Touristation.HTMLPages
{
    public partial class AddItinerary : System.Web.UI.Page
    {

        
        private bool ValidateInput()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (NOPTB.Text == "")
            {
                LblMsg.Text += "Name of place is required!" + "<br/>";
            }
            if (TimeTB.Text == "")
            {
                LblMsg.Text += "Time is required!" + "<br/>";
            }
            DateTime doe;
            result = DateTime.TryParse(DateTB.Text, out doe);
            if (!result)
            {
                LblMsg.Text += "Event date is invalid!" + "<br/>";
            }
            if (LocationTB.Text == "")
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

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Itinerary itn = new Itinerary();
            if (itn.GetEmployeeById(TimeTB.Text) != null)
            {
                LblMsg.Text = "Record already exists!";

            }
            else
            if (ValidateInput())
            {
                DateTime doe = Convert.ToDateTime(DateTB.Text);

                itn = new Itinerary(NOPTB.Text, TimeTB.Text, doe, LocationTB.Text);
                int result = itn.AddItinerary();
                if (result == 1)
                {
                    LblMsg.Text = "your event has been added successfully!";

                }
                else
                {
                    LblMsg.Text = "Something has gone wrong! please try again !";

                }
            }
        }

        protected void BtnRfrsh_Click(object sender, EventArgs e)
        {

            Response.Redirect("ViewItinerary.aspx");

        }

    }

}

    