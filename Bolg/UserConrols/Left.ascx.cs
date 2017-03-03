using Bolg.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.UserConrols
{
    public partial class Left : System.Web.UI.UserControl
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            InitRevert();
            InitHref();
        }

        private void InitRevert()
        {
            string sql = @"select Top 5 * from tb_Revert order by Time Desc";
            DataTable dt = db.GetDataSet(sql, "tbRevert");
            datalist.DataSource = dt.DefaultView;
            datalist.DataBind();
        }

        private void InitHref()
        {
            
                string sql = @"SELECT * FROM tb_Href";
            DataTable dt = db.GetDataSet(sql, "tbHref");
            dlHref.DataSource = dt.DefaultView;
            dlHref.DataBind();
        }
    }
}