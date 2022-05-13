<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPuestos.aspx.cs" Inherits="proyectoGasolinera.frmPuestos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Puestos</title>
    <link href="Resources/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="formulario text-center">
        <h2>Creación, actualización y eliminación de puestos</h2>
        <div class="form-campos">
            <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Enabled="False" Width="52px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre del puesto"></asp:Label>
            <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Caracteristicas del puesto"></asp:Label>
            <asp:TextBox ID="txtCaracteristicas" class="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Sueldo del puesto"></asp:Label>
            <asp:TextBox ID="txtSueldo" class="form-control" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="btnGuardar" class="btn btn-success" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
        <asp:Button ID="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
        <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
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
