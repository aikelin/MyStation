<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bolg.management.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Scripts/jquery-1.9.1.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" style="">
        <div style="height:200px"></div>
        <div style="margin: 0 auto; width: 300px; height: 340px; ">
            <div style="background-color: #3083eb; width: 300px; height: 300px; padding-top: 20px; padding-left: 20px; padding-right: 20px">
                <h2 style="color: #f2f7fa">后台登录</h2>
                <div>
                    <p runat="server" id="warm"></p>
                </div>
                    <p>
                        <asp:TextBox CssClass="form-control" runat="server" ID="users" Height="35" placeholder="用户名">
                        </asp:TextBox>
                    </p>
                    <div>
                        <asp:TextBox runat="server" CssClass="form-control" ID="userpwd" Height="35" placeholder="密码">
                        </asp:TextBox>
                    </div>
                 <%--   <script type="text/javascript">var child = document.getElementById("userpwd");
child.parentNode.removeChild(child);

</script>--%>
                    <div class="input-group" style="margin-top: 10px">
                        <asp:TextBox runat="server" CssClass="form-control" ID="txtValidateNum" Width="100" Height="35" placeholder="验证码">
                        </asp:TextBox>
                        <asp:Image runat="server" ID="imgValidate" Height="35" ImageUrl="ValidateNum.aspx" />
                        <button  id="btnReload" class="glyphicon glyphicon-repeat" onclick="<script >document.frames('imgValidate').location.reload()</script>"/>
                    </div>
                    <div style="margin: 10px 0">
                        <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-primary btn-block" OnClick="btnLogin_Click" Text="登录" />
                    </div>
            </div>
            <div  style="background-color: #f2f7fa; height: 40px ;"> 
                <table style="margin: 0 auto;height: 40px ">
                <tr>
                    <td>
                        <a href="#">注册新账号</a>|
                <a href="#">忘记密码？</a>
                    </td>
                </tr>                
            </table>
            </div>
            
        </div>
    </div>
    </form>
</body>
</html>
