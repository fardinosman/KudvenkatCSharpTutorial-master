<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_84_Real_Time_eks_Qeue_Colle.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table style="font-family:Arial; border:1px solid black;  text-align:center">
                <tr>
                    <td> Counter 1   </td>
                    <td> Counter 2   </td>
                    <td> Counter 3     </td>
                   
                </tr>
                <tr>
                    <td> <asp:TextBox ID="TxtCounter1" runat="server" BackColor="Blue" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox> </td>
                    <td>  <asp:TextBox ID="TxtCounter2" runat="server" BackColor="Blue" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox>  </td>
                    <td>  <asp:TextBox ID="TxtCounter3" runat="server" BackColor="Blue" Font-Size="Large" ForeColor="White" Width="150px"></asp:TextBox>  </td>
                 
                </tr>
                <tr>
                    <td>  <asp:Button ID="btncounter1" runat="server" Text="Next" Width="150px" OnClick="btncounter1_Click" />  </td>
                    <td>   <asp:Button ID="btncounter2" runat="server" Text="Next" Width="150px" OnClick="btncounter2_Click" />   </td>
                    <td>  <asp:Button ID="btncounter3" runat="server" Text="Next" Width="150px" OnClick="btncounter3_Click" />    </td>
                 
                </tr>
                <tr>
                    <td colspan="5"> <asp:TextBox ID="txtDisplay" runat="server" BackColor="Lime" Font-Size="Large" ForeColor="White" Width="500px"></asp:TextBox>  </td>
                    

                </tr>
                <tr>
                    <td colspan="5"> <asp:ListBox ID="listToken" Font-Size="Large" runat="server" Width="100px"></asp:ListBox></td>
                </tr>
                <tr>
                    <td colspan="5"> <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" OnClick="btnPrintToken_Click" /></td>
                </tr>
                <tr>
                    <td colspan="5"> <asp:Label ID="lblStatus" Font-Size="Large" runat="server" ></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
