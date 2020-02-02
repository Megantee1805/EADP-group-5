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

        public List<Entry> GetEntries(int userId)
        { 
            Entry entry = new Entry();
            List<Entry> eList;
            eList = entry.GetAll();
            return eList; 
        }

        public void BindDataList(int userId)
        {
            dataScore.DataSource = GetEntries(userId);
            dataScore.DataBind(); 
        }
    }
}