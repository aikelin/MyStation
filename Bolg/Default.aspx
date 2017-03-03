<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bolg.Default" %>

<%@ Register Src="~/UserConrols/ContentList.ascx" TagPrefix="uc1" TagName="ContentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ContentList runat="server" id="ContentList" />
</asp:Content>
