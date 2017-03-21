using Bolg.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bolg.management
{
    public partial class Login : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        CommonClass cc = new CommonClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Form.DefaultButton = btnLogin.ID;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = users.Text.Trim();
            string pwd = userpwd.Text.Trim();
            string validata = txtValidateNum.Text.Trim();
            string usertype;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                //Response.Write("<script>alert('用户名或密码不能为空！') </script>");
                Response.Write(cc.MessageBox("用户名或密码不能为空！"));
                return;
            }
            if(validata != Session["ValidateNum"].ToString())
            {
                //Response.Write("<script>alert('用户名或密码不能为空！') </script>");
                Response.Write(cc.MessageBox("验证码错误！"));
                return;
            }
            
            string md5pwd = db.GetMD5(pwd);
            string sql = @"select usertypeid from tb_user where username='" + username + "' and password='" + pwd + "'";
            object o = db.getExecuteScalar(sql);
            if (o != null)
            {
                usertype = o.ToString();
                Session["username"] = username;
                Session["usertype"] = usertype;
                Response.Redirect("ArticleManageList.aspx");
            }
            else
            {
                Response.Write(cc.MessageBox("登录失败！"));
            }
        }
    }
}