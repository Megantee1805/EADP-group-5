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
        Competition main; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Competition com = new Competition();
            int Id = int.Parse(Request.QueryString["Competition"]);
            main = com.GetCompetitionById(Id); 
            LblComName.Text = main.name; 
        }

        protected void btnEntrySubmit_Click(object sender, EventArgs e)
        { 
            Competition com; 
            Competition host = new Competition();
            string title = LblComName.Text;
            com = host.GetCompetitionById(main.Id); 
            Entry submit = new Entry();
            string userId = Session["Id"].ToString();
            submit.CheckForDuplicates(int.Parse(userId), com.Id); 
            if (submit == null)
            {
                string filename = Path.GetFileName(entryFile.FileName);
                string filePath = "~/Images" + filename;
                entryFile.SaveAs(Server.MapPath(filePath));
                submit.name = tbEntryName.Text;
                submit.description = tbEntryDescription.Text;
                submit.fileLink = filePath; 
                submit.UserId = int.Parse(userId);
                submit.ComId = com.Id;
                submit.AddEntry(submit);
                LblMsg.Text = "Success";
                LblMsg.ForeColor = Color.Green;
            }

            else
            {
                LblMsg.Text = "You have already submitted";
                LblMsg.ForeColor = Color.Red;
            }
             
        }
    }
}