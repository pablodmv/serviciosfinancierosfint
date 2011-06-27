<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoReal.aspx.cs" Inherits="FINTWeb.webForms.EstadoReal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB - Estado Real</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
</head>
<body>
    <div id="container">
            
    
            <form id="form1" runat="server">
            
    
        <div id="head">
            <h4>Estados de Cuenta</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>
        </div>
        <div id="central">
                <table id="tbl">
                    <tr>
                        <td><asp:Label ID="noCuentaLbl" runat="server" Text="NºCuenta:"></asp:Label></td>
                        <td><asp:DropDownList ID="selCuentaCmb" runat="server">
                            <asp:ListItem>12345</asp:ListItem>
                            <asp:ListItem>67888</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td> 
                        
                            <asp:Calendar ID="fechaDtPicker" runat="server" BackColor="White" 
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
                    <tr>
                        <td>
                            <asp:Button ID="realBtn" runat="server" Text="Real" Width="81px" 
                                onclick="realBtn_Click" />
                        </td>
                        <td>
                            <asp:Button ID="proyBtn" runat="server" Text="Proyectado" 
                                onclick="proyBtn_Click" />
                        </td>
                    </tr>
                </table>
                    
                
                <br />
                <asp:ListBox ID="lbEstados" runat="server" Width="307px"></asp:ListBox>
                <br />
                <table id="btnTbl">
                    <tr>
                        <td><asp:Button ID="backBtn" runat="server" Text="Atras" 
                                onclick="backBtn_Click" /></td>
                    </tr>
                </table>
                
        </div>
        <div id="foot">
            <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
        </div>
    
                
            </form>
    
    </div>
</body>
</html>
