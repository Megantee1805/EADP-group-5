using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ViewCompetitions : System.Web.UI.Page
    {
        public Competiton chosenCom;
        
        List<Competiton> cList = new List<Competiton>();
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();


        }

        private void RefreshGridView()
        {
            Competiton current = new Competiton();
            cList = current.SelectAvailableCompetitions();
            gvViewCompetitions.Visible = true;
            gvViewCompetitions.DataSource = cList;
            gvViewCompetitions.DataBind();
        }

        

       

       

        protected void gvViewCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gvViewCompetitions.SelectedIndex >= 0)
            {
                string ComName = gvViewCompetitions.SelectedRow.Cells[0].Text;
                Session["ComName"] = ComName;
                Server.Transfer("SubmitEntry.aspx");
            }
        }
    }

}