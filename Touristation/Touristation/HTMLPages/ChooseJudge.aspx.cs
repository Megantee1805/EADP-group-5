using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Touristation.BLL;

namespace Touristation.HTMLPages
{
    public partial class ChooseJudge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getPossibleJudges();
        }

        private void getPossibleJudges()
        {
            List<User> possibleJudges;
            User use = new User();
            int userId = int.Parse(Session["Id"].ToString());
            possibleJudges = use.GetAll(userId);

            foreach (User judge in possibleJudges)
            {
                ddJudges.DataSource = possibleJudges;
                ddJudges.DataTextField = "username";
                ddJudges.DataValueField = "Id";
                ddJudges.DataBind();
            }


        }
    }
}