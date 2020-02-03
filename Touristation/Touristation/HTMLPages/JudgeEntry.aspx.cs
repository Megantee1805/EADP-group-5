using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class JudgeEntry : System.Web.UI.Page
    {
        int Id; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Judge"]); 
            BindDataList(Id); 

        }

        public List<Entry> GetEntries(int comId)
        { 
            Entry entry = new Entry();
            List<Entry> eList;
            eList = entry.GetEntriesByCompetition(comId);
            return eList; 
        }

        public void BindDataList(int comId)
        {
            dataScore.DataSource = GetEntries(comId);
            dataScore.DataBind(); 
        }

        protected void dataScore_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string commandName = e.CommandName;
            if (commandName == "Judge")
            {
                DataListItem item = dataScore.SelectedItem; 
                LblEntry.Text = ((TextBox) item.FindControl("tbName")).Text; 
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int score = int.Parse(tbScore.Text); 
        }
    }
}