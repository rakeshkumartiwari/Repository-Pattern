<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCat.aspx.cs" Inherits="EFCodeFirstAnimalDb.Presentation.AddCat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Color :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
                    </td>
                     
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnReg" runat="server" OnClick="btnReg_Click" Text="Register" />
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                        <asp:Button ID="btnViewAll" runat="server" OnClick="btnViewAll_Click" Text="View All" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblError" runat="server" ForeColor="red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
