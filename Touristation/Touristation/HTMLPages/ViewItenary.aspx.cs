using Itinerary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itinerary
{
    public partial class ViewItinerary : System.Web.UI.Page
    {
        List<Itinerary> eList;

        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            Itinerary emp = new Itinerary();
            eList = emp.GetAllItems();

            // using gridview to bind to the list of employee objects
            GVItinerary.Visible = true;
            GVItinerary.DataSource = eList;
            GVItinerary.DataBind();
        }
        protected void GvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVItinerary.SelectedRow;
            Session["SSdate"] = row.Cells[0].Text;
            Session["SStime"] = row.Cells[1].Text;
            Session["SSNamePlace"] = row.Cells[2].Text;
            Session["SSLocation"] = row.Cells[3].Text;

            Response.Redirect("ItineraryUpdateForm.aspx");

        }
    }

}