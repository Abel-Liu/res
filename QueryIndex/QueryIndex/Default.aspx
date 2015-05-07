<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QueryIndex._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Storage:<asp:TextBox runat="server" ID="txtStorage"></asp:TextBox>
            <br />
            Contents:<asp:TextBox runat="server" ID="txtContent"></asp:TextBox>
            <asp:Button runat="server" ID="btnSearch" Text="Go" OnClick="btnSearch_Click" />
            <br />
            <br />
            <asp:Label runat="server" ID="lab" Text=""></asp:Label>
            <asp:DataGrid runat="server" ID="grid"></asp:DataGrid>
        </div>
    </form>
</body>
</html>
