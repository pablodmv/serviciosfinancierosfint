<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresarGastos.aspx.cs" Inherits="FINTWeb.webForms.IngresarGastos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">

    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - IngresarGastos</title>
    <style type="text/css">
        #form1
        {
            height: 365px;
        }
    </style>
</head>
<body>
    
    <div id="container">
            <form id="form1" runat="server">
   
        <div id="head">
            <h4>Ingresar Gastos</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>    
        </div>
        <div id="central">
   
        <table id="tbl">
            <tr>
                <td><asp:Label ID="noFacLbl" runat="server" Text="NºFactura:"></asp:Label></td>
                <td><asp:TextBox ID="nFacTxt" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="nFacTxt" ErrorMessage="Factura invalida." 
                ValidationExpression="^\d{5}"></asp:RegularExpressionValidator></td>
            </tr>
        
            <tr>
                <td><asp:Label ID="descLbl" runat="server" Text="Concepto:"></asp:Label></td>
                <td><asp:TextBox ID="descTxt" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        
            <tr>
                <td><asp:Label ID="montoLbl" runat="server" Text="Monto:"></asp:Label></td>
                <td><asp:TextBox ID="montoTxt" runat="server"></asp:TextBox></td>
                <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ErrorMessage="Monto invalido." ValidationExpression="^\d{7}" ControlToValidate="montoTxt"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td> 
                    <asp:Label ID="Label2" runat="server" Text="NºCuenta:"></asp:Label>
                </td>
                <td> 
                    <asp:DropDownList ID="selCuentaCmb" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        
            <tr>
                <td><asp:Label ID="fVenLbl" runat="server" Text="F.Vencimiento:"></asp:Label></td>
                <td>
                    <asp:Calendar ID="fVenDPicker" runat="server" BackColor="White" 
                    BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                    Width="200px">
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    </asp:Calendar>
                
                </td>
            </tr>
        
        </table>
        <table id="btnTbl">
            <tr>
                <td><asp:Button ID="backBtn" runat="server" Text="Atras" onclick="backBtn_Click" /></td>
                <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
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
