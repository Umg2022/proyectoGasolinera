<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="proyectoGasolinera.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="Resources/css/estilos.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <style type="text/css">
       
        .auto-style1 {
            display: block;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #212529;
            background-clip: padding-box;
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: .25rem;
            transition: none;
            border: 1px solid #ced4da;
            background-color: #fff;
        }
       
        </style>
</head>
<body>
    <div class="container well contenedor"  >
        
        <div class ="row">
            <div class="col-xs-12">
                <h2>
                    Iniciar Sesión</h2>
            </div>

        </div>
        <form runat="server" class="form-horizontal">

            <div class="form-group">
                <asp:Label ID="lblPasswor" runat="server" Text="Password" CssClass="control-label col-sm-2"></asp:Label>
                <div class ="col-sm-10">
                     <asp:TextBox ID="txtUsuario" runat="server" CssClass="auto-style1" Width="311px"></asp:TextBox>

                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="control-label col-sm-2"></asp:Label>
                <div class ="col-sm-10">
                     <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style1" Width="311px"></asp:TextBox>

                     <br />

                </div>
            </div>
            <div class ="form-group">
               </div>
                <asp:Button ID="Button1" runat="server"  Height="44px" OnClick="Button1_Click" Text="Ingresar"  CssClass="form-control btn btn-primary"  style="margin-left: 101px" Width="148px"/>
            </div>
            <div>
        </div>
        
    </form>
        
  
</body>
</html>
