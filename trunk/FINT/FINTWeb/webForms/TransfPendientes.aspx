<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransfPendientes.aspx.cs" Inherits="FINTWeb.webForms.TransfPendientes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="Stylesheet" type="text/css" href="../css/layout.css" />
    <title>FINT WEB - Trans. Pendientes</title>
</head>
<body>

    <form id="form1" runat="server">
    
    <div id="container">
        <div id="head">
            <h4>Transacciones Pendientes</h4>
            <asp:Label ID="usrLbl" runat="server"></asp:Label>
        </div>
        <div id="central">
            <table id="tbl">
                <tr>
                    <td><asp:ListBox ID="transLb" runat="server" Width="413px"></asp:ListBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="backBtn" runat="server" onclick="backBtn_Click" Text="Atras" />
                    </td>
                    <td>
                        <asp:Button ID="doneBtn" runat="server" onclick="doneBtn_Click" 
                            Text="Confirmar" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="msgLbl" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            
            </table>
            
        </div>
        <div id="foot">
            <asp:Label ID="Label1" runat="server" Text="FINT WEB" Visible="true"></asp:Label>
        </div>
    </div>
    
    </form>
</body>
</html>
