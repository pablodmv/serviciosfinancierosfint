<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarDepExt.aspx.cs" Inherits="FINTWeb.webForms.IngresarDepExt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - Ingresar DepExt</title>
    <style type="text/css">
        #form1
        {
            height: 203px;
        }
    </style>
</head>
<body>
    <div id="container">
        <div id="head">
        <h4>Ingresar Depositos-Extracciones</h4>
        <asp:Label ID="usrLbl" runat="server"></asp:Label>
    </div>
    
    <div id="central">
        <form id="form1" runat="server">
    
        <table id="tbl">
            <tr>
                <td><asp:Label ID="selCuentaLbl" runat="server" Text="Seleccionar Cuenta:"></asp:Label></td>
                <td><asp:DropDownList ID="listCuentaCmb" runat="server">
                    <asp:ListItem>Seleccione...</asp:ListItem>
                    <asp:ListItem>Cuenta1</asp:ListItem>
                    <asp:ListItem>Cuenta2</asp:ListItem>
                    </asp:DropDownList>
                </td>
            
            </tr>
            <tr>
                <td><asp:Label ID="montoLbl" runat="server" Text="Monto:"></asp:Label></td>
                <td><asp:TextBox ID="montoTxt" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="montoTxt" ErrorMessage="Monto invalido." 
                    ValidationExpression="^\d{7}"></asp:RegularExpressionValidator>
                </td>        
             
            </tr>
            <tr>
                <td><asp:Label ID="descLbl" runat="server" Text="Concepto:"></asp:Label></td>
                <td><asp:TextBox ID="descTxt" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" dir="ltr">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                        RepeatDirection="Horizontal" 
                        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem Text="Deposito" Value="Deposito"></asp:ListItem>
                        <asp:ListItem Text="Extracción" Value="Extraccion"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
        
        </table>
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
                <td> 
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
