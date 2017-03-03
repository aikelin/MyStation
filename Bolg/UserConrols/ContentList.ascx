<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContentList.ascx.cs" Inherits="Bolg.UserConrols.ContentList" %>
<style type="text/css">
    .alink {
        color: #105cb6; 
    font-size: 14px;
    font-weight: bold;
    text-decoration: underline;
    }
    .filter{
        line-height: 1.8em;
    margin-bottom: 5px;
    color: #333;
    overflow: hidden;
    padding-right: 5px;
    font-size: 12px;
    padding-top: 5px;
    }
    .post_item_foot{
        color: #555;
    padding-top: 5px;
    margin-left: 10px;
    }
    .post_item {
    border-bottom: 1px dotted #ccc;
    border-width: 1px;
    margin-bottom: 15px;
    padding-bottom: 15px;
}
</style>


<div style="">
    <div style="height:10px;border-bottom:1px solid #c8d3de;"></div>
    <asp:DataList runat="server" ID="dlContents" OnItemDataBound="dlContents_ItemDataBound">
        <ItemTemplate>
            <table class="post_item">
                <tr>
                    <td colspan="2">
                        <a class="alink" href="../ArticlePage.aspx?Articleid=<%# Eval("articleid") %>"><%# Eval("Subject") %></a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <img alt="" src="../Images/20160623170345.png" />
                    </td>
                    <td><asp:Label runat="server" CssClass="filter" ID="labelContent" Text='<%# Eval("Content") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2" class="post_item_foot">
                        <a href="#" ><%# Eval("Author") %></a><span >&nbsp 发表于<%# Eval("Time") %></span>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</div>
