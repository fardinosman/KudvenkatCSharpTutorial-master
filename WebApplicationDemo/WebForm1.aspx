<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <table style ="border:1px solid black"> 
            <tr>
                <td>Country Code: 
                    
                </td>
                <td>
                    <asp:TextBox ID="TxtCode" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Country Name

                </td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Country Capital

                </td>
                <td>
                    <asp:TextBox ID="TxtCapital" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="LabelMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
                
            </tr>
                </table>
        </div>
    </form>
</body>
</html>
