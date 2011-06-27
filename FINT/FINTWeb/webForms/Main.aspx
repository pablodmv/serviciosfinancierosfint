<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="FINTWeb.webForms.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
</head>
<body>
    <div id="menuContainer">
        <form id="formMain" runat="server">
    
    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
        DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
        ForeColor="#284E98" MaximumDynamicDisplayLevels="2" Orientation="Horizontal" 
        StaticSubMenuIndent="10px" Width="800px">
        <StaticSelectedStyle BackColor="#507CD1" />
        <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
        <DynamicMenuStyle BackColor="#B5C7DE" />
        <DynamicItemTemplate>
            <%# Eval("Text") %>
        </DynamicItemTemplate>
        <DynamicSelectedStyle BackColor="#507CD1" />
        <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
        <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        <Items>
            <asp:MenuItem Text="DatosPersonales" Value="DatosPersonales">
                <asp:MenuItem NavigateUrl="~/webForms/EditarUsuario.aspx" Text="Editar" 
                    Value="Editar"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/webForms/EliminarUsuario.aspx" Text="Desactivar" 
                    Value="Desactivar"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Cuentas" Value="Cuentas">
                <asp:MenuItem NavigateUrl="~/webForms/IngresarCuenta.aspx" Text="Nueva Cuenta" 
                    Value="NuevaCuenta"></asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Acciones" Value="Acciones">
                <asp:MenuItem NavigateUrl="~/webForms/IngresarGastos.aspx" Text="Gastos" 
                    Value="Gastos"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/webForms/IngresarPagos.aspx" Text="Pagos" 
                    Value="Pagos"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/webForms/IngresarDepExt.aspx" 
                    Text="Depositos-Extracciones" Value="DepExtr"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/webForms/Transferencia.aspx" Text="Transferencias" 
                    Value="Transferencias"></asp:MenuItem>
                <asp:MenuItem Text="Transferencias Pendientes" Value="TransfPendientes">
                </asp:MenuItem>
            </asp:MenuItem>
            <asp:MenuItem Text="Estado de Cuentas" Value="EstadoCuentas">
                <asp:MenuItem Text="Ver" Value="Real" NavigateUrl="~/webForms/EstadoReal.aspx"></asp:MenuItem>
                
            </asp:MenuItem>
        </Items>
    </asp:Menu>

      </form>
      <asp:Label ID="usrLbl" runat="server"></asp:Label>  
    </div>
    
    </body>
</html>
