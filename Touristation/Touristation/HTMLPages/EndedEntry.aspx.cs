using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class EndedEntry : System.Web.UI.Page
    {
        List<Entry> eList;
        int Id; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Competition com = new Competition();
            Id = int.Parse(Request.QueryString["Competition"]);
            com = com.GetCompetitionById(Id);
            RefreshGridView(Id); 
        }
        
        private void RefreshGridView(int comId)
        {
            Entry current = new Entry();
            current.tallyVotes(Id); 
            eList = current.GetEntriesByCompetition(Id);
            gvViewEntries.Visible = true;
            gvViewEntries.DataSource = eList;
            gvViewEntries.DataBind();

        }
    }
}