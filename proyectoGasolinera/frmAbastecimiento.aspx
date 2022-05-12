<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAbastecimiento.aspx.cs" Inherits="proyectoGasolinera.frmAbastecimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PROVEEDOR</div>
        <asp:TextBox ID="txtPrueba" runat="server" OnTextChanged="txtPrueba_TextChanged"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    <asp:DropDownList ID="ddProveedor" runat="server" Height="16px" Width="338px">
                    </asp:DropDownList>
    </form>
</body>
</html>
