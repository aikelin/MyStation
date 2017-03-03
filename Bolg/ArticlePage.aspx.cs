using Bolg.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg
{
    public partial class ArticlePage : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string articleid = Request["articleid"] == null ? null : Request["articleid"].ToString();
                if (articleid != null)
                {
                    LoadPage(articleid);
                }
            }
        }

        private void LoadPage(string id)
        {
            string sql = @"select a.*,username from tb_article a join tb_user where articleid='" + id + "'";
            DataTable dataTable = db.GetDataSet(sql, "Article");
            if (dataTable.Rows.Count > 0)
            {
                div.InnerHtml = dataTable.Rows[0]["Content"].ToString();
                title.InnerText = dataTable.Rows[0]["articletitle"].ToString();
                author.InnerText = dataTable.Rows[0]["username"].ToString();
                labelTime.Text = dataTable.Rows[0]["time"].ToString();
            }
        }

    }
}