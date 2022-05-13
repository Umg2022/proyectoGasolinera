<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSucursal.aspx.cs" Inherits="proyectoGasolinera.frmSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sucursal</title>
    <link href="Resources/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
       <form id="form1" runat="server" class="formulario text-center">
           <h2>Creación, actualización y eliminación de sucursales</h2>
           <div class="form-campos">
                 <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
                 <asp:TextBox ID="txtID" runat="server" Width="35px" Enabled="False" OnTextChanged="txtID_TextChanged"></asp:TextBox>
               <br />  
               <asp:Label class="campos-label" ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                 <asp:TextBox ID="txtNombre" class="form-control" runat="server" placeholder="ingrese nombre"></asp:TextBox>
               <br />  
               <asp:Label class="campos-label text-left" ID="lblDireccion" runat="server" Text="Dirección"></asp:Label>
                 <asp:TextBox ID="txtDireccion" class="form-control" runat="server" placeholder="ingrese dirección"></asp:TextBox>
               <br />  
               <asp:Label class="campos-label" ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
                 <asp:TextBox ID="txtTelefono" runat="server" class="form-control" placeholder="ingrese teléfono"></asp:TextBox>
           </div>
           <br />
                 <asp:Button ID="btnGuardar" class="btn btn-success" runat="server" OnClick="btnGuardar_Click1" Text="Guardar"/>
                 <asp:Button ID="btnActualizar" class="btn btn-primary" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" Enabled="False"/>
                 <asp:Button ID="btnEliminar" class="btn btn-danger" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" Enabled="False"/>
                 <asp:GridView ID="GridView1" runat="server" class="table" 
                            OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                 </form>        
</body>
</html>
