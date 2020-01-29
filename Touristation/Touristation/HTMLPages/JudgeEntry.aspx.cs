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
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataList(); 
        }

        public List<Entry> GetEntries()
        { 
            Entry entry = new Entry();
            List<Entry> eList;
            eList = entry.GetAll();
            return eList; 
        }

        public void BindDataList()
        {
            dataScore.DataSource = GetEntries();
            dataScore.DataBind(); 
        }
    }
}