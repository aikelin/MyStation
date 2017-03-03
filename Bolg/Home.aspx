<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Bolg.Home" %>

<%@ Register Src="~/UserConrols/ArticleList.ascx" TagPrefix="uc1" TagName="ArticleList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .post-date-ribbon {
            width: 100px;
            height: 25px;
            text-align: center;
            line-height: 25px;
            color: #fff;
            font-size: 12px;
            margin-top: -30px;
            position: relative;
            background-color: #0099FF;
        }

        .corner {
            position: absolute;
            left: -10px;
            width: 0;
            height: 0;
            border-style: solid;
            border-width: 0 0 10px 10px;
            border-color: transparent transparent #00aaff transparent;
        }
    </style>
    <div class="container">
        <div class="row">
            <div class="col-md-8 col-sm-12" style="padding-right:60px">
                <%--<asp:DataList runat="server" ID="dlArticle" >
                    <ItemTemplate>
                        <div class="form-control" style="clear: both; margin-bottom: 40px; background-color: #fff; padding: 20px; width: auto; border: 1px solid #cdcdcd; min-height: 130px;">
                            <div class="post-date-ribbon">
                                <div class="corner"></div>
                                <%# DateTimeChange(Eval("Time").ToString()) %></div>
                            <h4><a href="#"><%# Eval("Subject") %></a></h4>
                            <p>
                                <a style="margin-right: 10px" href="#">
                                    <img style="float: left" src="Images/20160623170345.png" />
                                </a>
                                <%# Eval("abstract") %>
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
                </form>--%>
                <uc1:ArticleList runat="server" ID="ArticleList" />
            </div>
            <div class="col-md-4 col-sm-12" style="background-color: #fff; height: 500px">
            </div>
        </div>
    </div>

</asp:Content>
