<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="ArticlePage.aspx.cs" Inherits="Bolg.ArticlePage" %>

<%@ Register Src="~/UserConrols/ArticleList.ascx" TagPrefix="uc1" TagName="ArticleList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="background-color:#fff;text-align:center">
        <h1 runat="server" id="title" ></h1>
        <br />
        <br />
        <a runat="server"  href="#" id="author"></a> &nbsp&nbsp 发表于&nbsp&nbsp
        <asp:Label runat="server" ID="labelTime"></asp:Label>
        <br />
        <br />
        <div id="div" runat="server">
            
        </div>
    </div>
</asp:Content>
