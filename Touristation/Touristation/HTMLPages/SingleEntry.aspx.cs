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
    public partial class ViewSingleEntry : System.Web.UI.Page
    {
        int Id;
        Entry entry; 
        protected void Page_Load(object sender, EventArgs e)
        {
             
            Entry current = new Entry();
            Id = int.Parse(Request.QueryString["Entry"]);
            entry = current.GetEntryById(Id);
            tbEntryTitle.Text = entry.name;
            tbEntryDesc.Text = entry.description;
            imgEntry.ImageUrl = entry.fileLink;
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Entry ent = new Entry();
            ent = entry;
            ent.name = tbEntryTitle.Text;
            ent.description = tbEntryDesc.Text;
            String filename = Path.GetFileName(editFile.FileName);
            if (filename != null)
            {
                string filePath = "~/Images" + filename;
                editFile.SaveAs(Server.MapPath(filePath));
                ent.fileLink = filePath;
            }
            else
            {
                ent.fileLink = imgEntry.ImageUrl; 

            }
            
            ent.Update(ent);
            int userId = int.Parse(Session["Id"].ToString());
            Response.Redirect("ViewOwnEntries.aspx?User=" + userId); 
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            tbEntryTitle.Enabled = true;
            tbEntryDesc.Enabled = true;
            btnEdit.Visible = false;
            btnSave.Visible = true;
            Lblfile.Visible = true;
            editFile.Visible = true;
            imgEntry.Visible = false;
            
            }
    }
}