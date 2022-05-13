<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoUsuario.aspx.cs" Inherits="proyectoGasolinera.frmTipoUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tipo de usuario</title>
    <link href="Resources/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
          <form id="form1" runat="server" class="formulario text-center">
               <h2>Tipo de usuario</h2>
                 <div class="form-campos">
                            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
                            <asp:TextBox ID="txtID" runat="server" Width="35px" Enabled="False"></asp:TextBox>
                     <br />
                            <asp:Label class="campos-label" ID="lblNombre" runat="server" Text="Nuevo tipo de usuario"></asp:Label>
                            <asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="ingrese el tipo"></asp:TextBox>
                    </div>
                        <br />
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click1" Text="Guardar" class="btn btn-success"/>
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" class="btn btn-primary" Enabled="False"/>
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" class="btn btn-danger" Enabled="False"/>
                        <asp:GridView ID="GridView1" runat="server" class="table" 
                            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
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
