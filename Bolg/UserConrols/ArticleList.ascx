﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ArticleList.ascx.cs" Inherits="Bolg.UserConrols.ArticleList" %>
<asp:DataList runat="server" ID="dlArticle">
    <ItemTemplate>
        <div class="form-control" style="clear: both; margin-bottom: 40px; background-color: #fff; padding: 20px; width: auto; border: 1px solid #cdcdcd; min-height: 130px;">
            <div class="post-date-ribbon">
                <div class="corner"></div>
                <%# DateTimeChange(Eval("Time").ToString()) %>
            </div>
            <h4><a href="../ArticlePage.aspx?articleid=<%# Eval("articleid") %>"><%# Eval("articletitle") %></a></h4>
            <p>
                <a style="margin-right: 10px" href="#">articleid
                                    <img style="float: left" src="Images/20160623170345.png" />
                </a>
                <%# Eval("articleabstract") %>
            </p>
        </div>
    </ItemTemplate>
</asp:DataList>
<form runat="server">
    当前页：<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>
    总页数：<asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
    <asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">第一页</asp:LinkButton>
    <asp:LinkButton ID="lbntUp" runat="server" OnClick="lbntUp_Click">上一页</asp:LinkButton>
    <asp:LinkButton ID="lbtnDown" runat="server" OnClick="lbtnDown_Click">下一页</asp:LinkButton>
    <asp:LinkButton ID="lbtnLast" runat="server" OnClick="lbtnLast_Click">最后一页</asp:LinkButton>
</form>
