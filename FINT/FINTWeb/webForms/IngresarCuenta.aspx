<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarCuenta.aspx.cs" Inherits="FINTWeb.webForms.IngresarCuenta" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - IngresarCuenta </title>
    <style type="text/css">
        #form1
        {
            height: 194px;
        }
    </style>
</head>
<body>

    <div id="container">
        <div id="head">
        <h4>Ingresar Cuenta</h4>
        <asp:Label ID="usrLbl" runat="server"></asp:Label>
    </div>
    <div id="central">
        <form id="form1" runat="server">
    
        <table id="tbl">
        
            <tr>
                <td><asp:Label ID="noCuentaLbl" runat="server" Text="NºCuenta:"></asp:Label></td>
                <td><asp:TextBox ID="noCuentaTxt" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                ControlToValidate="noCuentaTxt" ErrorMessage="Numero de cuenta incorrecto." 
                ValidationExpression="^\d{5}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td><asp:Label ID="descLbl" runat="server" Text="Descripción:"></asp:Label></td>
                <td><asp:TextBox ID="descTxt" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Label ID="saldoLbl" runat="server" Text="Saldo:"></asp:Label></td>
                <td><asp:TextBox ID="saldoTxt" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ControlToValidate="saldoTxt" ErrorMessage="Monto Invalido." 
                ValidationExpression="^\d{7}"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td><asp:Label ID="provLbl" runat="server" Text="Proveedor Asociado:"></asp:Label></td>
                <td> <asp:DropDownList ID="provCmb" runat="server">
                        <asp:ListItem>Seleccione...</asp:ListItem>
                        <asp:ListItem>Proveedor1</asp:ListItem>
                        <asp:ListItem>Proveedor2</asp:ListItem>
                        </asp:DropDownList>
                </td>
            
            </tr>
        
        </table>
        
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                        onclick="doneBtn_Click" />&nbsp; </td>
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
