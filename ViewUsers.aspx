<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewUsers.aspx.cs" Inherits="ViewUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvUsers" runat="Server" AutoGenerateColumns="true">
            </asp:GridView>
        </div>
        <div>&nbsp;
        </div>
        <div>
            <asp:Button ID="Register" runat="server" Text="Register/Create User" OnClick="View_Click" />
            &nbsp;
        </div>
    </form>
</body>
</html>
