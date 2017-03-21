<%@ Page Title="" Language="C#" MasterPageFile="~/management/management.Master" ValidateRequest="false" AutoEventWireup="true" CodeBehind="ArticleAdd.aspx.cs" Inherits="Bolg.management.ArticleAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../ueditor1_4_3_3-utf8-net/ueditor.config.js"></script>
    <script src="../ueditor1_4_3_3-utf8-net/ueditor.all.js"></script>
    <div>
    <div class="container">
            <div style="text-align: center">
                <h1 runat="server"  id="h1Add">文章添加</h1>
                <h1 runat="server"  id="h1Edit">文章修改</h1>                
            </div>
            <table class="table table-responsive">
                <tr>
                    <td>标题</td>
                    <td colspan="2"><asp:TextBox runat="server" ID="tbTitle" MaxLength="30" CssClass="form-control"></asp:TextBox></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td>摘要</td>
                    <td colspan="2"><asp:TextBox runat="server" ID="tbAbstract" MaxLength="200" CssClass="form-control"   Height="80" TextMode="MultiLine"></asp:TextBox></td>
                    <td>
                        <asp:Button runat="server" ID="btnAdd" CssClass="btn btn-sm btn-primary form-control" Text="添加" OnClick="btnAdd_Click" />
                        <asp:Button runat="server" ID="btnUpdate" CssClass="btn btn-sm btn-primary form-control" Text="更新" OnClick="btnUpdate_Click"/>
                    </td>
                </tr>
            </table>
            <div>
                正文

                <textarea id="myEditor" runat="server"  ClientIDMode="Static"></textarea>   
<script type="text/javascript">
        var ue = new baidu.editor.ui.Editor();
        ue.render("myEditor");   //这里填写要改变为编辑器的控件id
</script>
            </div>

        </div>
        </div>
</asp:Content>
