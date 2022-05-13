<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFactura.aspx.cs" Inherits="proyectoGasolinera.frmFactura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            width: 488px;
            text-align: center;
        }
        .auto-style2 {
            width: 399px;
        }
        .auto-style3 {
            width: 2317px;
            text-align: center;
        }
        .auto-style4 {
            margin-left: 4px;
        }
        .auto-style5 {
            width: 488px;
            height: 23px;
            text-align: center;
        }
        .auto-style6 {
            width: 399px;
            height: 23px;
        }
        .auto-style8 {
            margin-left: 0px;
        }
        .auto-style9 {
            width: 94%;
            margin-right: 0px;
        }
        .auto-style11 {
            height: 21px;
            text-align: right;
        }
        .auto-style13 {
            width: 1306px;
            text-align: center;
        }
        .auto-style14 {
            width: 2317px;
            height: 23px;
            text-align: center;
        }
        .auto-style15 {
            width: 399px;
            height: 23px;
            text-align: left;
        }
        .auto-style17 {
            margin-left: 15px;
        }
        .auto-style18 {
            width: 488px;
            text-align: center;
            height: 26px;
        }
        .auto-style19 {
            width: 399px;
            height: 26px;
        }
        .auto-style20 {
            text-align: right;
        }
        .auto-style21 {
            width: 488px;
            text-align: center;
            height: 32px;
        }
        .auto-style22 {
            width: 399px;
            height: 32px;
        }
        .auto-style23 {
            width: 2317px;
            text-align: right;
            height: 32px;
        }
        .auto-style24 {
            margin-left: 0px;
            margin-bottom: 0px;
        }
        .auto-style26 {
            margin-left: 0px;
            margin-right: 5px;
        }
        .auto-style27 {
            width: 2317px;
            height: 23px;
            text-align: right;
        }
        .auto-style28 {
            margin-left: 28px;
        }
        .auto-style31 {
            margin-top: 13px;
        }
        .auto-style32 {
            text-align: center;
        }
        .auto-style33 {
            margin-left: 24px;
        }
    </style>
</head>
<body style="width: 1389px; height: 596px">
    <form id="form1" runat="server">
        <table class="auto-style9"; border ="1">
            <tr>
                <td class="auto-style11" colspan="3">
                    <br />
                    <div class="auto-style32">
                    <img src="logo.JPG" alt="logo" width="200" class="auto-style8"/>
                    </div>
                    
                    Sucursal&nbsp; <asp:DropDownList ID="ddSucursal" runat="server" AutoPostBack="True" Font-Overline="True" Height="16px" Width="145px" CssClass="auto-style31">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style20" colspan="3">&nbsp;Fecha y Hora&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtFecha" runat="server" CssClass="auto-style28" Height="16px" Width="247px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FACTURA NO.<asp:TextBox ID="txtFactura" runat="server" OnTextChanged="txtFactura_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">Empleado</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="ddEmpleado" runat="server" Height="16px" Width="338px" OnSelectedIndexChanged="ddEmpleado_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3" rowspan="2">

                    <asp:Button ID="btnGuardar" runat="server" Height="47px" Text="Guardar" CssClass="form-control btn btn-primary" Width="256px" OnClick="btnGuardar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cliente</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddCliente" runat="server" Height="17px" Width="170px" AutoPostBack="True" OnSelectedIndexChanged="ddCliente_SelectedIndexChanged">
                    </asp:DropDownList>
                &nbsp; NIT
                    <asp:TextBox ID="txtNit" runat="server" CssClass="auto-style4" Enabled="False" Width="115px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" CssClass="form-control btn btn-primary" Height="29px" Text="Agregar Cliente" Width="105px" />
                </td>
            </tr>
            <tr>

                <td class="auto-style21">Tipo de Servicio</td>
                <td class="auto-style22">
                    <asp:DropDownList ID="ddTipoServicio" runat="server" AutoPostBack="True" CssClass="auto-style8" Height="17px" OnSelectedIndexChanged="ddTipoServicio_SelectedIndexChanged" Width="335px">
                        <asp:ListItem>Auto Servicio</asp:ListItem>
                        <asp:ListItem Selected="True">Servicio Completo</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style23">Tipo de Combustible&nbsp;&nbsp;
                    <asp:DropDownList ID="ddTipoCombustible" runat="server" Height="22px" Width="183px" AutoPostBack="True" CausesValidation="True" CssClass="auto-style24" OnSelectedIndexChanged="ddTipoCombustible_SelectedIndexChanged">
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Precio Galón Q.<asp:TextBox ID="txtPrecio" runat="server" CssClass="auto-style4" Enabled="False" Height="16px" Width="175px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Cantidad a comprar en Q</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtCantidad" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td class="auto-style27">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Bomba De Combustible&nbsp;
                    <asp:DropDownList ID="ddBomba" runat="server" AutoPostBack="True" CssClass="auto-style8" Height="16px" Width="158px" OnSelectedIndexChanged="ddBomba_SelectedIndexChanged">
                    </asp:DropDownList>
&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Forma de Pago</td>
                <td class="auto-style15"><strong>
                    <asp:DropDownList ID="ddForma" runat="server" AutoPostBack="True" CssClass="auto-style8" Height="16px" Width="334px">
                    </asp:DropDownList>
                    </strong></td>
                <td class="auto-style14">
                    <asp:Button ID="Insertar" runat="server" OnClick="Insertar_Click" Text="Agregar" CssClass="form-control btn btn-primary" Width="188px" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvArticulo" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style26" Height="67px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1305px" DataKeyNames="idTipoCombustible" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" OnRowCommand="gvArticulo_RowCommand" Font-Bold="True" Font-Italic="False">
            <Columns>
                <asp:CommandField HeaderText="Quitar" SelectText="Quitar" ShowSelectButton="True" />
                <asp:BoundField DataField="Tipo Combustible" HeaderText="Tipo Combustible" />
                <asp:BoundField DataField="Cantidad en galones" HeaderText="Cantidad en galones" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" />
                <asp:BoundField DataField="No Bomba" HeaderText="No Bomba" />
                <asp:BoundField DataField="Forma De Pago" HeaderText="Forma De Pago" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <p class="auto-style13">
            Total a Pagar<asp:TextBox ID="txtTotal" runat="server" CssClass="auto-style17" Height="16px" Width="182px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total de Galones<asp:TextBox ID="txtGalones" runat="server" CssClass="auto-style33" Enabled="False" Width="171px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
