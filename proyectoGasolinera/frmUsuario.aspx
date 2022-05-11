<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="proyectoGasolinera.frmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 58px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            margin-left: 40px;
        }
        .auto-style4 {
            margin-left: 26px;
        }
        .auto-style5 {
            margin-left: 60px;
        }
        .auto-style6 {
            font-size: x-large;
        }
        .auto-style7 {
            margin-top: 0px;
        }
        .auto-style8 {
            margin-left: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong><span class="auto-style6">Ingreso De Usuarios</span></strong><br />
            <br />
            ID EMPLEADO<asp:TextBox ID="txtEmpleado" runat="server" CssClass="auto-style1" Width="132px"></asp:TextBox>
        </div>
        <p>
            TIPO USUARIO&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="auto-style3" Width="136px"></asp:TextBox>
        </p>
        <p>
            NOMBRE USUARIO<asp:TextBox ID="txtNombre" runat="server" CssClass="auto-style4" Width="132px"></asp:TextBox>
        </p>
        <p>
            CONTRASEÑA<asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style5" Width="132px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="30px" OnClick="Button1_Click" Text="Guardar" Width="103px" />
        &nbsp;
            <asp:Button ID="Button2" runat="server" CssClass="auto-style7" Height="29px" OnClick="Button2_Click" Text="Actualizar" Width="94px" />
            <asp:Button ID="Button3" runat="server" CssClass="auto-style8" Height="31px" OnClick="Button3_Click" Text="Eliminar" Width="114px" />
        </p>
        <p>
            Codigo Usuario <asp:TextBox ID="txtCodigoUsuario" runat="server" CssClass="auto-style5" Width="132px"></asp:TextBox>
        </p>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
