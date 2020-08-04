<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminControl.ascx.cs" Inherits="ifshop.admin.adminControl" %>
<%@ Register src="menu.ascx" tagname="menu" tagprefix="uc1" %>
<div>
    benner admin
</div>
<table cellspacing="0" cellspacing="0" style="width:100%;">
    <tr>
        <td style="width:200px;"><uc1:menu ID="menu1" runat="server" /></td>
        <td style="width:10px;">&nbsp;</td>
        <td><asp:PlaceHolder ID="plLoad" runat="server"></asp:PlaceHolder></td>
    </tr>
</table>





