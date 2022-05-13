<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="proyectoGasolinera.frmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Usuario</title>
    <link href="Resources/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="formulario text-center">
        <h2>Creación, actualización y eliminación de usuarios</h2>
        <div class="form-campos">
            <asp:Label ID="Label1" runat="server" Text="ID" Visible="False"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Enabled="False" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Empleado"></asp:Label>
            <asp:DropDownList ID="ddEmpleado" runat="server" class="form-control"></asp:DropDownList>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Tipo de usuario"></asp:Label>
            <asp:DropDownList ID="ddTipo" runat="server" class="form-control"></asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nombre de usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" class="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control"></asp:TextBox>
        </div>
        <br />
            <asp:Button ID="btnGuardar" runat="server" Text="Crear" class="btn btn-success" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" class="btn btn-primary" OnClick="btnActualizar_Click" Enabled="False" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" OnClick="btnEliminar_Click" Enabled="False" /> 
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
     </form>
</body>
</html>
