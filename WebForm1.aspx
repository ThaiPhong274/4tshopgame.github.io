<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DoanWebNhomPV.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView runat="server" ID="List" OnPagePropertiesChanging="List_PagePropertiesChanging" GroupPlaceholderID="GroupPlaceholder" ItemPlaceholderID="ItemPlaceholder">
                <LayoutTemplate>
                    <div id="GroupPlaceholder"  runat="server"></div>
                        
                </LayoutTemplate>
                <GroupTemplate>
                    <div id="ItemPlaceholder" runat="server"></div>
                </GroupTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("maloai") %>'>
                        <asp:Panel ID="Panel1" runat="server" CssClass="category">
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("tenloai") %>'></asp:Label>
                        </asp:Panel>
                    </asp:LinkButton>
                </ItemTemplate>
            </asp:ListView>
            <asp:DataPager ID="DataPager1" PagedControlID="List" PageSize="5" runat="server">
                            <Fields>
                                <asp:NumericPagerField ButtonType="Button" />
                            </Fields>
                        </asp:DataPager>
        </div>
    </form>
</body>
</html>
