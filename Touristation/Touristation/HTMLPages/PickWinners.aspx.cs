using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class PickWinners : System.Web.UI.Page
    {
        List<Competiton> cList; 
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView(); 
        }

        private void RefreshGridView()
        {
            Competiton current = new Competiton();
            cList = current.SelectAvailableCompetitions();
            foreach (Competiton c in cList)
            {
                current.countEntries(c);
            }
            gvViewCompetitions.Visible = true;
            gvViewCompetitions.DataSource = cList;
            gvViewCompetitions.DataBind();
        }
    }
}