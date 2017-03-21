<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeBehind="ArticleEditPage.aspx.cs" Inherits="Bolg.ArtticlePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../ueditor1_4_3_3-utf8-net/ueditor.config.js"></script>
    <script src="../ueditor1_4_3_3-utf8-net/ueditor.all.js"></script>
</head>
<body>
    <form id="form1" runat="server">
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

                <textarea id="container" name="container" runat="server"></textarea>
                <script type="text/javascript">
                    var ue = UE.getEditor('container');
                </script>
            </div>

        </div>
    </form>
</body>
</html>
