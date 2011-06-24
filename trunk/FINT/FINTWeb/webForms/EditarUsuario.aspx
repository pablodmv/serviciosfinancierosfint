<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUsuario.aspx.cs" Inherits="FINTWeb.webForms.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB - Editar Usuario</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <style type="text/css">
        #form1
        {
            height: 154px;
        }
    </style>
</head>
<body>
    <div id="container">
        <div id="head">
        <h4>Editar Usuario</h4>
        <asp:Label ID="usrLbl" runat="server"></asp:Label>
    </div>
    <div id="central">
        <form id="form1" runat="server">
    
        <table id="tbl">
            <tr>
                <td>
                    <asp:Label ID="nomLbl" runat="server" Text="Nuevo Nombre:"></asp:Label>            
                </td>
                <td>
                    <asp:TextBox ID="nomTxt" runat="server"></asp:TextBox>            
                </td>
            
            </tr>
            <tr>
                <td>
                    <asp:Label ID="pwdLbl" runat="server" Text="Nuevo Password:"></asp:Label>            
                </td>
                <td>
                    <asp:TextBox ID="pwdTxt" runat="server" TextMode="Password"></asp:TextBox>            
                </td>
            </tr>
        </table>
        <br />
        <br />        
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                        onclick="doneBtn_Click" /></td>
                
            </tr>
        </table>
    
        <asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label>
    
    </form>
    </div>
    <div id="foot">
        <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
    </div>
    </div>
</body>
</html>
