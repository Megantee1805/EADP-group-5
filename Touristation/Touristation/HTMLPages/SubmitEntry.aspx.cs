﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Touristation.HTMLPages
{
    public partial class SubmitEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblComName.Text = Session["ComName"].ToString(); 
        }
    }
}