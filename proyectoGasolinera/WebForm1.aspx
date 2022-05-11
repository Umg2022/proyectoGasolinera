<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumirWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 329px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="ID De Empleado"></asp:Label>
            <asp:TextBox ID="txtempleado" runat="server" Height="16px" style="margin-left: 52px" Width="231px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Tipo de Usuario"></asp:Label>
            <asp:TextBox ID="txtTipoUsuario" runat="server" OnTextChanged="txtTipoUsuario_TextChanged" style="margin-left: 58px" Width="228px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp; Nombre Usuario<asp:TextBox ID="txtNombreUsuario" runat="server" style="margin-left: 52px" Width="231px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtContra" runat="server" style="margin-left: 87px" Width="227px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnGuardar" runat="server" Height="41px" OnClick="btnGuardar_Click" style="margin-left: 160px" Text="Guardar" Width="151px" />
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Codigo Usuario"></asp:Label>
            <asp:TextBox ID="txtCodigoUsuario" runat="server" style="margin-left: 60px" Width="111px"></asp:TextBox>
            <asp:Button ID="btnActualizar" runat="server" Height="39px" OnClick="btnActualizar_Click" style="margin-left: 35px" Text="Actualizar" Width="89px" />
            <asp:Button ID="btnEliminar" runat="server" Height="37px" OnClick="btnEliminar_Click" style="margin-left: 23px" Text="Eliminar" Width="93px" />
        </p>
        <p>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="28px" Text="Buscar" Width="87px" OnClick="Button1_Click" />
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
