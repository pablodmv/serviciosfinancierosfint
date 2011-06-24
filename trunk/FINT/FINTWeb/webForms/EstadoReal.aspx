<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstadoReal.aspx.cs" Inherits="FINTWeb.webForms.EstadoReal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FINT WEB - Estado Real</title>
    <link rel="Stylesheet" type="text/css" href="../css/layout.css" />
</head>
<body>
    <div id="container">
            
    
        <div id="head">
            <h4>Estado Real</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>
        </div>
        <div id="central">
            <form id="form1" runat="server">
                <table id="tbl">
                    <tr>
                        <td><asp:Label ID="noCuentaLbl" runat="server" Text="NºCuenta:"></asp:Label></td>
                        <td><asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>12345</asp:ListItem>
                            <asp:ListItem>67888</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
                <table id="btnTbl">
                    <tr>
                        <td><asp:Button ID="backBtn" runat="server" Text="Atras" /></td>
                        <td><asp:Button ID="doneBtn" runat="server" Text="Aceptar" 
                                onclick="doneBtn_Click" /></td>
                    </tr>
                </table>    
                
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                    <Columns>
                        <asp:BoundField HeaderText="Fecha" />
                    </Columns>
                </asp:GridView>
                
                
            </form>
        </div>
        <div id="foot">
            <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
        </div>
    
    </div>
</body>
</html>
