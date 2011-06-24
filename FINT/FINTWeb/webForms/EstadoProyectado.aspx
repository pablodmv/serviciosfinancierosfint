<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoProyectado.aspx.cs" Inherits="FINTWeb.webForms.EstadoProyectado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB - Estado Proyectado</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
</head>
<body>
    <div id="container">
            
    
        <div id="head">
            <h4>Estado Proyectado</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>
        </div>
        <div id="central">
    
            <form id="form1" runat="server">
                <table id="tbl">
                    <tr>
                        <td><asp:Label ID="noCuentaLbl" runat="server" Text="NºCuenta:"></asp:Label></td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>123234</asp:ListItem>
                            <asp:ListItem>68858</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    
                    </tr>
                    <tr>
                        <td><asp:Label ID="dateLbl" runat="server" Text="Proyectado al:"></asp:Label></td>
                        <td><asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
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
                            </asp:Calendar></td>
                    
                    </tr>
                    
                </table>
                <table id="btnTbl">
                    <tr>
                        <td><asp:Button ID="backBtn" runat="server" Text="Atras" /></td>
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
