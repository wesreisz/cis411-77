<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtAddressInput" runat="server" /> 
        <asp:button ID="btnSubmit" runat="server" Text="GeoCode Me" /><br />
        <asp:Label ID="lblAddressFullStuff" runat="server" />
    </div>
    </form>
</body>
</html>
