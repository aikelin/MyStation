﻿using Bolg.App_Code;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Bolg
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataListBind();
            }
        }

        private void DataListBind()
        {
            int current_page = Convert.ToInt32(lblCurrent.Text);
            string articletype = Request["articletypeid"] == null ? null : Request["articletypeid"].ToString();
            string sql = @"select * from tb_Article";
            if (articletype != null)
            {
                sql += " where articletypeid='" + articletype + "'";
            }
            sql += " order by Time desc";

            DataTable dataTable = db.GetDataSet(sql, "Article");
            PagedDataSource ps = new PagedDataSource();
            ps.DataSource = FluentDB.Fluent_DB().Sql("select * from tb_article").QueryMany<tb_article>();
            ps.AllowPaging = true;
            ps.PageSize = 2;
            lblTotal.Text = ps.PageCount.ToString();
            ps.CurrentPageIndex = current_page - 1;
            lbtnFirst.Enabled = true;
            lbntUp.Enabled = true;
            lbtnDown.Enabled = true;
            lbtnLast.Enabled = true;
            if (current_page == 1)
            {
                lbtnFirst.Enabled = false;
                lbntUp.Enabled = false;
            }
            if (current_page == Convert.ToInt32(lblTotal.Text))
            {
                lbtnLast.Enabled = false;
                lbtnDown.Enabled = false;
            }
            dlArticle.DataSource = ps;
            dlArticle.DataBind();
        }

        public string DateTimeChange(string dateStr)
        {
            DateTime dat;
            try
            {
                dat = Convert.ToDateTime(dateStr);
            }
            catch (Exception ex)
            {
                return "Error Datetime Type";
            }

            return dat.ToString("yyyy年MM月dd日", DateTimeFormatInfo.InvariantInfo);

        }

        protected void lbtnFirst_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = "1";
            DataListBind();
        }
        protected void lbtnDown_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = (Convert.ToInt32(lblCurrent.Text) + 1).ToString();
            DataListBind();
        }
        protected void lbntUp_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = (Convert.ToInt32(lblCurrent.Text) - 1).ToString();
            DataListBind();
        }
        protected void lbtnLast_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = lblTotal.Text;
            DataListBind();
        }
    }
}