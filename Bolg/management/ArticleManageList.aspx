<%@ Page Title="" Language="C#" MasterPageFile="~/management/management.Master" AutoEventWireup="true" CodeBehind="ArticleManageList.aspx.cs" Inherits="Bolg.management.ArticleList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:DataList runat="server" ID="dlArticle">
            <ItemTemplate>
                <div class="form-control" style="clear: both; margin-bottom: 40px; background-color: #fff; padding: 20px; width: auto; border: 1px solid #cdcdcd; min-height: 150px;">
                    <div>
                        <%# DateTimeChange(Eval("Time").ToString()) %>
                    </div>
                    <h4><a href="ArticleAdd.aspx?articleid=<%# Eval("articleid") %>"><%# Eval("articletitle") %></a></h4>
                    <p>
                        <%# Eval("articleabstract") %>
                    </p>
                </div>
            </ItemTemplate>
        </asp:DataList>
        当前页：<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>
        总页数：<asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
        <asp:LinkButton ID="lbtnFirst" runat="server" OnClick="lbtnFirst_Click">第一页</asp:LinkButton>
        <asp:LinkButton ID="lbntUp" runat="server" OnClick="lbntUp_Click">上一页</asp:LinkButton>
        <asp:LinkButton ID="lbtnDown" runat="server" OnClick="lbtnDown_Click">下一页</asp:LinkButton>
        <asp:LinkButton ID="lbtnLast" runat="server" OnClick="lbtnLast_Click">最后一页</asp:LinkButton>
    </div>
</asp:Content>
