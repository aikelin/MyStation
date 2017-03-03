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
    public partial class MasterPage1 : System.Web.UI.MasterPage
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitNav();
            }
        }

        private void InitNav()
        {
            string html = "";
            string sql = @"select * from tb_nav where isusing=1";
            DataTable dataTable = db.GetDataSet(sql, "tb_nsv");
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                string navid = dataTable.Rows[i]["navid"].ToString();
                string fatherid = dataTable.Rows[i]["fatherid"].ToString();
                string navname = dataTable.Rows[i]["navname"].ToString();
                string articletypeid = dataTable.Rows[i]["articletypeid"].ToString();                

                html += "<li ><a href='Home.aspx?articletypeid=" + articletypeid + "'>" + navname + "</a>" + "</li>";
            }
            ulnav.InnerHtml = html;
        }
    }
}