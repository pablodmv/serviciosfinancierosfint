<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transferencia.aspx.cs" Inherits="FINTWeb.webForms.Transferencia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - Transferencia</title>
    <style type="text/css">
        #form1
        {
            height: 230px;
        }
    </style>
</head>
<body>

    <div id="container">
            <form id="form1" runat="server">

        <div id="head">
            <h4>Transferencia</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>    
        </div>
        <div id="central">

        <table id="tbl">
            <tr>
                <td><asp:Label ID="cuentaIniLbl" runat="server" Text="Cuenta Origen:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cuentaIniCmb" runat="server">
                    <asp:ListItem>Seleccione...</asp:ListItem>
                    <asp:ListItem>Cuenta1</asp:ListItem>
                    <asp:ListItem>Cuenta2</asp:ListItem>
                    </asp:DropDownList>
                </td>
            
            </tr>
            <tr>
                <td><asp:Label ID="cuentaFinLbl" runat="server" Text="Cuenta Destino:"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="cuentaFinCmb" runat="server">
                    </asp:DropDownList>
                </td>
                
            
            </tr>
            <tr>
                <td><asp:Label ID="montoLbl" runat="server" Text="Monto:"></asp:Label></td>
                <td><asp:TextBox ID="montoTxt" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="montoTxt" ErrorMessage="Monto inválido." 
                    ValidationExpression="^\d{7}"></asp:RegularExpressionValidator>
                </td>        
            </tr>
            <tr>
                <td><asp:Label ID="descLbl" runat="server" Text="Concepto:"></asp:Label></td>
                <td><asp:TextBox ID="descTxt" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                
            </tr>
        
        </table>
    <br />
    
    <table id="btnTbl">
        <tr>
            <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
            <td> 
                <asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                    onclick="doneBtn_Click" /></td>
        </tr>
    </table>
    
    <br />
    <asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label>
    
        </div>
        <div id="foot">
            <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
        </div>
    
    </form>    
    </div>
    
</body>
</html>
