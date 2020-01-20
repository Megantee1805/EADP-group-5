using System;
using System.Collections.Generic;
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