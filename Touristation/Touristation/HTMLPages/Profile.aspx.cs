using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Touristation
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            else
            {
                uname.Text = Session["Username"].ToString();

               

                
            }            
        }

        protected void editPage_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            DDCountry.DataSource = CountryList();
            DDCountry.DataBind();
            
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            LblMsg.ForeColor = Color.Red;
            if (validate() == true)
            {
                LblMsg.ForeColor = Color.Green;
                LblMsg.Text = "Success";
            }
        }

        public bool validate()
        {
            bool complete = true; 
            if (tbEditName.Text.Length == 0)
            {
                LblMsg.Text += "Name cannot be empty!";
                complete = false; 
            }

            if (tbEditEmail.Text.Contains("@") == false)
            {
                LblMsg.Text += "Email cannot be empty!";
                complete = false;
            }

            if (tbEditPass.Text.Length <= 6)
            {
                LblMsg.Text += "Password is too short !";
                complete = false;
            }

            if (tbEditPass.Text != tbEditConfirm.Text)
            {
                LblMsg.Text += "Passwords do not match !";
                complete = false;
            }

            return complete; 

        }


        public static List<string> CountryList()
        {
            List<string> CultureList = new List<string>();

            //getting  the specific  CultureInfo from CultureInfo class
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo getCulture in getCultureInfo)
            {
                //creating the object of RegionInfo class
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                //adding each county Name into the arraylist
                if (!CultureList.Contains(GetRegionInfo.EnglishName))
                {
                    CultureList.Add(GetRegionInfo.EnglishName);
                }
            }
            //sorting array by using sort method to get countries in order
            CultureList.Sort();
            //returning country list
            return CultureList;
        }

    
    }
}