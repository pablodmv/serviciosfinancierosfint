<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AppCliente._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AppCliente</title>
    <style type="text/css">
        #form1
        {
            height: 269px;
        }
        .style1
        {
            width: 68px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="get">
    <h4>Login</h4>
        <table id="tbl">
        
            <tr>
                <td><asp:Label ID="usuarioLbl" runat="server" Text="Usuario: "></asp:Label></td>
                <td class="style1"><asp:TextBox ID="usuarioTxt" runat="server"></asp:TextBox> </td>
            </tr>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Contraseña: "></asp:Label></td>
                <td class="style1"><asp:TextBox ID="pwdTxt" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Button ID="doneBtn" runat="server" Text="Aceptar" onclick="doneBtn_Click" /> 
                </td>
            </tr>
        
        </table>
            
            
    <asp:Label ID="msgLbl" runat="server" ForeColor="Red" Text="Usuario o Contraseña incorrectos." 
        Visible="False"></asp:Label>
    <br />
            
            
    </form>
</body>
</html>
