<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnrestrictedFileUpload.aspx.cs" Inherits="VulnSmoke.UnrestrictedFileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUploadControl" runat="server"/>
        <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
        </div>
    </form>
</body>
</html>
