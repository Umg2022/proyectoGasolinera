<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTipoCombustible.aspx.cs" Inherits="proyectoGasolinera.frmTipoCombustible" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tipo de combustile</title>
    <link href="Resources/css/style.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="contenedor">
                <form id="form1" runat="server" class="formulario text-center">
                    <h2>Tipo de Combustible</h2>
                    <p>
                            <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
                            <asp:TextBox ID="txtID" runat="server" Width="35px"></asp:TextBox>
                    </p>
                    <div class="form-campos">
                            <asp:Label class="campos-label" ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                            <asp:TextBox ID="txtNombre" runat="server" class="form-control" placeholder="ingrese nombre"></asp:TextBox>
                            <asp:Label class="campos-label" ID="lblPrecioAuto" runat="server" Text="Precio autoservicio"></asp:Label>
                            <asp:TextBox ID="txtPrecioAuto" runat="server" class="form-control" placeholder="ingrese precio"></asp:TextBox>
                            <asp:Label class="campos-label" ID="lblPrecioCompleto" runat="server" Text="Precio servicio completo"></asp:Label>
                            <asp:TextBox ID="txtPrecioCompleto" runat="server" class="form-control" placeholder="ingrese precio"></asp:TextBox>
                    </div>
                        <br />
                        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click1" Text="Guardar" class="btn btn-success"/>
                        <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" class="btn" Enabled="False"/>
                        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" class="btn btn-danger" Enabled="False"/>
                    <br />
                    <br />
                    <div class="busqueda">
                    <asp:Label ID="lblBuscar" runat="server" Text="Buscar"></asp:Label>
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                    </div>
                    <br />
                    <div class="contenedor-form">
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
                    </div>
                 </form>
    </div>         
</body>
</html>
