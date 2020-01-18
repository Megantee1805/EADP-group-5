﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Entry entry; 
            Entry current = new Entry();
            int Id = int.Parse(Request.QueryString["Entry"]);
            entry = current.GetEntryById(Id);
            tbEntryTitle.Text = entry.name;
            tbEntryDesc.Text = entry.description;
            imgEntry.ImageUrl = entry.fileLink; 
        }
    }
}