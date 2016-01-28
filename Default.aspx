<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello World</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Please enter your name then click OK."></asp:Label>
        <br />
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" 
            Width="88px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
            Text="Cancel" Width="88px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
        <asp:Label ID="lblGreeting" runat="server" Font-Bold="True" Font-Names="Arial" 
            Font-Size="XX-Large" ForeColor="Red" Text="Hello, World!"></asp:Label>
    
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblCount" runat="server" BackColor="#00CC00" Text="Count = 0"></asp:Label>
    

        <br /> 
        <br />

        <% Write_Start_Time(); %>

    </div>
    </form>
</body>
</html>
