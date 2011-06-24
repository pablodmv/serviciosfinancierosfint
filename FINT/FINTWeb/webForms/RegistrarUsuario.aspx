<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="FINTWeb.webForms.RegistrarUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB - Registrar Usuario</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <style type="text/css">
        #form1
        {
            height: 198px;
        }
    </style>
</head>
<body>
    <div id="container">
        <div id="head">
        <h4>Registrar Usuario</h4>
    </div>

    <div id="central">
        <form id="form1" runat="server">
        
        <table id="tbl">
            
            <tr>
                <td><asp:Label ID="nomLbl" runat="server" Text="Nombre:"></asp:Label></td>
                <td><asp:TextBox ID="nomTxt" runat="server"></asp:TextBox></td>
            </tr>        
            <tr>
                <td><asp:Label ID="loginLbl" runat="server" Text="Login:"></asp:Label></td>
                <td><asp:TextBox ID="loginTxt" runat="server"></asp:TextBox></td>      
            </tr>
            <tr>
                <td><asp:Label ID="pwdLbl" runat="server" Text="Password:"></asp:Label></td>
                <td><asp:TextBox ID="pwdTxt" runat="server" TextMode="Password"></asp:TextBox></td>
                
            </tr>
            
        </table>
        <br />
        <br />
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" onclick="doneBtn_Click" /></td>
                
            </tr>
        </table>
        <br />
        
        <asp:Label ID="msgLbl" runat="server" ForeColor="Red" 
            Text="Todos los datos son requeridos." Visible="False"></asp:Label>
        
     </form>
    </div>
    <div id="foot">
        <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
    </div>

    
    </div>
    </body>
</html>
