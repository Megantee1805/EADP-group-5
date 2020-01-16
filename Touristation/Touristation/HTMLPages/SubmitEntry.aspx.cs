using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing; 
using Touristation.BLL;
using System.IO;

namespace Touristation.HTMLPages
{
    public partial class SubmitEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblComName.Text = Session["ComName"].ToString(); 
        }

        protected void btnEntrySubmit_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(entryFile.FileName);
            string filePath = "~/Images" + filename; 
            entryFile.SaveAs(Server.MapPath(filePath)); 
            Competiton com; 
            Competiton host = new Competiton();
            string title = LblComName.Text;
            com = host.GetCompetitionByName(title); 
            Entry submit = new Entry();
            submit.name = tbEntryName.Text;
            submit.description = tbEntryDescription.Text;
            submit.fileLink = filePath; 
            string userId = Session["Id"].ToString(); 
            submit.UserId = int.Parse(userId);
            submit.ComId = com.Id;
            submit.AddEntry(submit);
            LblMsg.Text = "Success";
            LblMsg.ForeColor = Color.Green; 
        }
    }
}