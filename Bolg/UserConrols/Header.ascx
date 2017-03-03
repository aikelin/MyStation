<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="Bolg.UserConrols.Header" %>
<div style="width:778px;height:157px; background-image: url('../Images/banner.jpg');">
    <div style="margin-left:50px;height:128px">
        <a>首页</a>
        <a>博客文章</a>
        <a>帮助</a>
    </div>
    <div style="text-align:center;padding-top:5px">
        用户名：<asp:TextBox runat="server" Width="65px" ID="tbName"></asp:TextBox>
        密码:<asp:TextBox runat="server" ID="tbPassworld" Width="65px"></asp:TextBox>
        验证码<asp:TextBox runat="server" ID="tbValidate"  Width="65px"></asp:TextBox>
        <asp:Image runat="server" ID="img" style="vertical-align:middle" ImageUrl="ValidateString.aspx" />
    </div>
</div>