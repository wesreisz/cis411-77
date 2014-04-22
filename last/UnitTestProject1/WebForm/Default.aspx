<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>GeoCode App</h3>
        <asp:TextBox ID="txtAddressToEncode" runat="server" />
        <asp:Button ID="btn" runat="server" Text="GeoCode"/><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
