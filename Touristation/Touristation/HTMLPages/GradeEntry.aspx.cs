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
        int count;
        int Id;
        int ComId; 
        protected void Page_Load(object sender, EventArgs e)
        {
            Entry entry; 
            Entry current = new Entry();
            Id = int.Parse(Request.QueryString["Entry"]);
            entry = current.GetEntryById(Id);
            tbEntryTitle.Text = entry.name;
            tbEntryDesc.Text = entry.description;
            imgEntry.ImageUrl = entry.fileLink;
            ComId = entry.ComId; 
            count = entry.votes; 
        }

        protected void btnVote_Click(object sender, EventArgs e)
        {
            count += 1;
            Entry upEnt; 
            Entry voted = new Entry();
            upEnt = voted.GetEntryById(Id);
            upEnt.votes = count; 
            voted.CountVotes(upEnt);
            Response.Redirect("ViewEntries.aspx?Competition=" + ComId); 
        }
    }
}