<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="challenge.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Generate one-time password:
                <asp:Button ID="Button1" runat="server" Text="Generate" OnClick="Button1_Click" /><br />
                <asp:Label ID="11" runat="server" />
        </div>
    </form>
</body>
</html>
