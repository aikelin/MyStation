<%@ Page Title="" Language="C#" MasterPageFile="~/management/management.Master" AutoEventWireup="true" CodeBehind="NavManager.aspx.cs" Inherits="Bolg.management.NavManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="color:#428bca">
        <table>
            <thead>
                <td></td>
            </thead>
            <tr></tr>
        </table>
    <asp:GridView ID="GridView1" runat="server" CssClass="container table-hover table-bordered" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit"
            OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="navid" HeaderText="栏目编号" ReadOnly="True" />
                <asp:BoundField DataField="navname" HeaderText="栏目名称" />
                <asp:BoundField DataField="isusing" HeaderText="是否启用" />
                <asp:BoundField DataField="fatherid" HeaderText="父级栏目编号" />
                <asp:BoundField DataField="discrimination" HeaderText="描述" />
                <asp:CommandField ShowEditButton="True"  HeaderText="操作"/>
            </Columns>
        <EditRowStyle/>
        <RowStyle  />
        
        </asp:GridView>
        </div>
</asp:Content>
