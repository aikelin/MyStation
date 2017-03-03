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
    public partial class ContentList : System.Web.UI.UserControl
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            InitContentList();
        }

        private void InitContentList()
        {
            string sql = @"SELECT * FROM tb_Article";
            DataTable dt = new DataTable();
            dt = db.GetDataSet(sql,"tbArticle");
            dlContents.DataSource = dt.DefaultView;
            dlContents.DataBind();
        }

        protected void dlContents_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            var lab = (Label)e.Item.Controls[0].FindControl("labelContent");
             if (lab.Text.Length > 50)
            {
                lab.Text = lab.Text.Substring(0, 50) + "......";
            }
        }
    }
}