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
            Competiton com = new Competiton();
            int Id = int.Parse(Request.QueryString["Competition"]);
            com = com.GetCompetitionById(Id);
            RefreshGridView(Id);
            
        }

        private void RefreshGridView(int comId)
        {
            Entry current = new Entry();
            eList = current.GetEntriesByCompetition(comId);
            gvViewEntries.Visible = true;
            gvViewEntries.DataSource = eList;
            gvViewEntries.DataBind();
        }

        protected void gvViewEntries_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName == "View")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                GridViewRow gvr = gvViewEntries.Rows[Index];
                int entId = int.Parse(gvr.Cells[0].Text);
                Response.Redirect("GradeEntry.aspx?Entry=" + entId);
            }
        }
    }
}