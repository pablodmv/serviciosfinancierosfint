<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarUsuario.aspx.cs" Inherits="FINTWeb.webForms.EliminarUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - Desactivar Usuario</title>
    <style type="text/css">
        #form1
        {
            height: 64px;
        }
    </style>
</head>
<body>

    <div id="container">
        <div id="head">
        <h4>Desactivar Usuario</h4>
    <asp:Label ID="usrLbl" runat="server"></asp:Label>
    </div>
    <div id="central">
        <form id="form1" runat="server">
    
        <table id="tbl">
            <tr>
                <td><asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label></td>
            
            </tr>
                    
        </table>
            
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
                <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                        onclick="doneBtn_Click" /></td>    
            </tr>
        
        </table>
        
    </form>
    </div>
    <div id="foot">
        <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
    </div>
    </div>
    
</body>
</html>
