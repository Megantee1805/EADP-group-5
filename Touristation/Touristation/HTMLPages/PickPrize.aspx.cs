using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class PickPrize : System.Web.UI.Page
    {
        DateTime start;
        DateTime end;
        string method; 
        protected void Page_Load(object sender, EventArgs e)
        {
            string title = Session["ComTitle"].ToString();
            LblTitle.Text = title;
            string desc = Session["ComDesc"].ToString();
            LblDesc.Text = desc;
            method = Session["method"].ToString();
            LblMethod.Text = method; 
            start = DateTime.Parse(Session["start"].ToString());
            LblStart.Text = start.ToString("MM/dd/yyyy");
            end = DateTime.Parse(Session["end"].ToString());
            LblEnd.Text = end.ToString("MM/dd/yyyy");
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(prizeLink.FileName);
            string filePath = "~/Images" + filename;
            prizeLink.SaveAs(Server.MapPath(filePath));
            Competition com = new Competition();
            com.name = LblTitle.Text;
            com.description = LblDesc.Text;
            com.startDate = start;
            com.JudgingCriteria = method;
            com.prize = filePath; 
            com.endDate = end;
            com.UserId = int.Parse(Session["Id"].ToString());
            com.addCompetition(com);
        }
    }
}