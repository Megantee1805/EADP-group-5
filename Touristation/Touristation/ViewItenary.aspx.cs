using Itenary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itenary
{
    public partial class ViewItenary : System.Web.UI.Page
    {
        List<ItenaryX> eList;

        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            ItenaryX emp = new ItenaryX();
            eList = emp.GetAllItems();

            // using gridview to bind to the list of employee objects
            GVItenary.Visible = true;
            GVItenary.DataSource = eList;
            GVItenary.DataBind();
        }
        protected void GvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVItenary.SelectedRow;
            Session["SSdate"] = row.Cells[0].Text;
            Session["SStime"] = row.Cells[1].Text;
            Session["SSNamePlace"] = row.Cells[2].Text;
            Session["SSLocation"] = row.Cells[3].Text;

            Response.Redirect("ItenaryUpdateForm.aspx");

        }
    }

}