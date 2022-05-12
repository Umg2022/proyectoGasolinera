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
            Escoja el proveedor
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            Escoja el empleado&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            Escoja el tipo de combustible
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <br />
            Cantidad comprada
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Precio del combustible comprado
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
    </form>
</body>
</html>
