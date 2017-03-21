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
    public partial class ArtticlePage : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        CommonClass cc = new CommonClass();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!cc.Check(this))
                {
                    Response.Redirect("../management/Login.aspx");
                }
                string userid = ViewState["userid"] == null ? "1" : ViewState["userid"].ToString();
                string articleid = Request["articleid"] == null ? null:Request["articleid"].ToString();
                InitPage(articleid);
            }
        }

        private void InitPage(string articleid)
        {
            if(articleid == null)
            {
                h1Edit.Visible = false;
                btnUpdate.Visible = false;
            }
            else
            {
                h1Add.Visible = false;
                btnAdd.Visible = false;
                LoadAtricle(articleid);
            }
        }

        private void LoadAtricle(string id)
        {
            string sql = @"select * from tb_Article where ArticleID ='" + id +"'";           
            DataTable dataTable = db.GetDataSet(sql, "Article");
            if (dataTable.Rows.Count > 0)
            {
                tbTitle.Text = dataTable.Rows[0]["articletitle"].ToString();
                tbAbstract.Text = dataTable.Rows[0]["articleabstract"].ToString();
                container.InnerText = dataTable.Rows[0]["Content"].ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string subject = tbTitle.Text.ToString();
            string abstracts = tbAbstract.Text.ToString();
            string content = container.InnerText.ToString() ;
            string articleid = Request["articleid"] == null ? null : Request["articleid"].ToString();
            string sql = @"update tb_Article set articletitle = '" + subject + "',articleabstract='" + abstracts + "',Content='" + content + "' where articleid='" + articleid + "'";
            int re = db.Update(sql);
            if (re > 0)
            {
                Response.Write(cc.MessageBox("更新成功！"));
                LoadAtricle(articleid);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string userid = ViewState["userid"] == null ? "1" : ViewState["userid"].ToString();
            string subject = tbTitle.Text.ToString();
            string abstracts = tbAbstract.Text.ToString();
            string content = container.InnerText.ToString();
            string sql = @"Insert into tb_Article (articletitle,articleabstract,Content,authorid) values( '" + subject + "','" + abstracts + "','" + content + "'," + userid + ")";
            string lastInsertId = db.Insert(sql);
            if (lastInsertId !=null)
            {
                Response.Write(cc.MessageBox("添加成功！"));
                LoadAtricle(lastInsertId);
            }
            else{
                Response.Write(cc.MessageBox("糟糕出现错误了！"));
            }
        }
    }
}