<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="newCatogri.ascx.cs" Inherits="ifshop.admin.News.newCatogri" %>
<div>danh sách tin tức</div>
<form runat="server">
    <asp:MultiView ID="mul" runat="server" ActiveViewIndex="0">
        <asp:View ID="v1" runat="server">
            <div>
                <asp:Repeater ID="rptnew" runat="server">
                    <HeaderTemplate>
                        <table style="width: 100%;">
                            <tr>
                                <td style="width: 300px;">MASP</td>
                                <td style="width: 50px;">TENSP</td>
                                <td style="width: 100px;">MALSP</td>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#: Eval("MASP")%></td>
                            <td><%#: Eval("TENSP")%></td>
                            <td><%#: Eval("MALSP")%></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div>

                <div>
                    <asp:LinkButton ID="addnew" runat="server" OnClick="addnew_Click">addnew</asp:LinkButton>
                </div>

            </div>
        </asp:View>
        <asp:View ID="v2" runat="server">

            <table>

                <tr>
                    <td>MASP</td>
                    <td>
                        <asp:TextBox ID="txtMA" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>TENSP</td>
                    <td>
                        <asp:TextBox ID="txtTEN" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>MALSP</td>
                    <td>
                        <asp:TextBox ID="txtMALOAI" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn" runat="server" Text="CẬP NHẬT" OnClick="btn_Save" />
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</form>

