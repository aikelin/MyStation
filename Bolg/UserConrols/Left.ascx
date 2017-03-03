<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Left.ascx.cs" Inherits="Bolg.UserConrols.Left" %>

    <table style="background-image:url(../Images/left.jpg);width: 221px; height: 533px;background-repeat:no-repeat;" cellpadding="0" cellspacing="0">
        <tr><td colspan="2" style="width: 221px; height: 33px;"></td></tr>
        <tr>
            <td style="vertical-align: top; width: 17px;  height: 187px;"></td>
            <td style="width: 204px; height: 187px;vertical-align:top;" align="right"> 
                <asp:Calendar runat="server" ID="calendar" Font-Size="8pt" Height="173px" Width="204px"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 17px;  height: 187px;"></td>
            <td style="width: 221px; height: 187px"> 
                <asp:DataList ID="datalist" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <a href="#"><%#  Eval("Subject") %></a>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top; width: 17px;  height: 187px;"></td>
            <td style="width: 221px; height: 187px"> 
                <asp:DataList runat="server" ID="dlHref">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td><a href='<%# Eval("Url") %>' ><%# Eval("name") %></a></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
