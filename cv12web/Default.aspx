<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cv12web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="firstNumber" runat="server"></asp:TextBox>
            <asp:DropDownList ID="operationsList" runat="server">
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="secondNumber" runat="server"></asp:TextBox>
            <asp:Button ID="computeBtn" Text="Compute" runat="server" onclick="Calculator_Service"/>
        </div>
    </form>
</body>
</html>
