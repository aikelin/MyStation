using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.management
{
    public partial class management : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_quit_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["usertype"] = null;
            Response.Redirect("../management/Login.aspx");
        }
    }
}