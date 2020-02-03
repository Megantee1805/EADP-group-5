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
            if (!IsPostBack) {
            
            BindDataList(Id); 
            }
            

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
                dataScore.SelectedIndex = e.Item.ItemIndex;
                DataListItem item = e.Item;
                Entry score; 
                Entry entry = new Entry();
                HiddenField identity = (HiddenField)item.FindControl("entryNo");
                score = entry.GetEntryById(int.Parse(identity.Value));
                TextBox marks = (TextBox)item.FindControl("tbScore");
                score.score = int.Parse(marks.Text);
                entry.Update(score);
                // Response.Redirect("JudgeEntry.aspx?Judge=" + Id);
            }
        }
        
    }
}