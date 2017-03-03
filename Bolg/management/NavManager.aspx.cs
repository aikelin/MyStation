using Bolg.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.management
{
    public partial class NavManager : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewBind();
            }
            
        }

        public void GridViewBind()
        {
            string sql = @"select * from tb_nav where isusing =1";
            DataTable dataTable = db.GetDataSet(sql, "tb_nav");

            //绑定DataList控件
            GridView1.DataSource = dataTable;//设置数据源，用于填充控件中的项的值列表
            GridView1.DataKeyNames = new string[] { "navid" };
            GridView1.DataBind();//将控件及其所有子控件绑定到指定的数据源
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //设置GridView控件的编辑项的索引为选择的当前索引
            GridView1.EditIndex = e.NewEditIndex;
            //数据绑定
            GridViewBind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //设置GridView控件的编辑项的索引为－1，即取消编辑
            GridView1.EditIndex = -1;
            //数据绑定
            GridViewBind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //取得编辑行的关键字段的值
            string navId = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //取得文本框中输入的内容
            string navName = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString();
            string isUsing = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString();
            string fatherId = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString();
            string discrimination = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString(); 
            string sql = "update tb_nav set navname='" + navName + "',isusing='" + isUsing + "',fatherid='" + fatherId + "',discrimination='" + discrimination + "' where navid=" + navId;
            int re = db.Update(sql);
            GridView1.EditIndex = -1;
            GridViewBind();
        }
    }
}