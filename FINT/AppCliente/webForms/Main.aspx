<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="AppCliente.webForms.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>AppCliente</title>
</head>
<body>
    <div id="container">
        <div id="head">
            <h4>Aplicación Cliente</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>
        </div>
        <div id="central">
            <form id="form1" runat="server">
                
                <table id="tbl">
                    <tr>
                        <td><asp:Label ID="selProvLbl" runat="server" Text="Seleccionar Proveedor:"></asp:Label></td>
                        <td><asp:DropDownList ID="cliCmb" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td><asp:Button ID="verCuentasBtn" runat="server" onclick="verCuentasBtn_Click" 
                    Text="Ver Cuentas" /></td>
                    </tr>
                    
                    <tr>
                        <td>
                            <asp:GridView ID="gridCuentas" runat="server" 
                            onselectedindexchanged="gridCuentas_SelectedIndexChanged">
                            <Columns>
                            <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
                            </Columns>
                            </asp:GridView>
                        
                        </td>
                    
                    </tr>
                    <tr>
                        <td><asp:Label ID="noCuentaLbl" runat="server" Text="NºCuenta:"></asp:Label></td>
                        <td><asp:TextBox ID="noCuentaTxt" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="montoLbl" runat="server" Text="Monto:"></asp:Label></td>
                        <td><asp:TextBox ID="montoTxt" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="montoTxt" ErrorMessage="Monto inválido." 
                            ValidationExpression="^\d{7}"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td><asp:Label ID="noCompLbl" runat="server" Text="NºComprobante:"></asp:Label></td>
                        <td><asp:TextBox ID="noCompTxt" runat="server"></asp:TextBox></td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="noCompTxt" ErrorMessage="Comprobante inválido." 
                            ValidationExpression="^\d{4}"></asp:RegularExpressionValidator>
                        
                        </td>
                    </tr>
                    
                </table>
                <table id="tblBtn">
                    <tr>
                        <td><asp:Button ID="backBtn" runat="server" Text="Atras" /></td>
                        <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" /></td>
                    </tr>
                </table>
                
                
                
    
            </form>
        </div>
        <div id="foot">
        <asp:Label ID="Label1" runat="server" Text="APP CLIENTE" Visible="true"></asp:Label>
        </div>
    </div>

    
</body>
</html>
