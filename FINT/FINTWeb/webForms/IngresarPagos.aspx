<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarPagos.aspx.cs" Inherits="FINTWeb.webForms.IngresarPagos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - Ingresar Pagos</title>
    <style type="text/css">
        #form1
        {
            height: 138px;
        }
    </style>
</head>
<body>

    <div id="container">
        <div id="head">
            <h4>Ingresar Pagos</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>    
        </div>
        <div id="central">
            <form id="form1" runat="server">
    
                <table id="tbl">
                    <tr>
                        <td><asp:Label ID="gastoLbl" runat="server" Text="Seleccionar Gasto:"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="listGastosCmb" runat="server">
                            <asp:ListItem>Seleccione...</asp:ListItem>
                            <asp:ListItem>Gasto1</asp:ListItem>
                            <asp:ListItem>Gasto2</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        
                        </td>
                        
                        
                    </tr>
                    <tr>
                        <td><asp:Label ID="Label1" runat="server" Text="Seleccionar Cuenta:"></asp:Label></td>
                        <td>
                        <asp:DropDownList ID="selCuentaCmb" runat="server">
                        <asp:ListItem>Seleccione...</asp:ListItem>
                        <asp:ListItem>Cuenta1</asp:ListItem>
                        <asp:ListItem>Cuenta2</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                        
                        </td>
                    
                    </tr>
                
                </table>
        
                <table id="btnTbl">
                    <tr>
                        <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                                onclick="doneBtn_Click" /></td>
                    
                    </tr>
                </table>
    
            <br />
            <asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label>
    
    </form>    
        
        </div>
        <div id="foot">
            <asp:Label ID="Label2" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
        </div>
    </div>
</body>
</html>
