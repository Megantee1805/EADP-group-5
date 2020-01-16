using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL; 

namespace Touristation.HTMLPages
{
    public partial class ViewEntries : System.Web.UI.Page
    {
        List<Entry> eList; 
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView(); 
        }

        private void RefreshGridView()
        {
            Entry current = new Entry();
            eList = current.GetAll();
            gvViewEntries.Visible = true;
            gvViewEntries.DataSource = eList;
            gvViewEntries.DataBind(); 
        }
    }
}