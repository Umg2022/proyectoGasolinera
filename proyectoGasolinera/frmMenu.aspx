<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMenu.aspx.cs" Inherits="proyectoGasolinera.frmMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
  <div class="container-fluid">
      <img src="logo.JPG" alt="logo" width="125px/">
    <a class="navbar-brand" href="#">Corporación Formula 1</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        
        
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Ventas
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
            <li><a class="dropdown-item" href="#">Agregar Cliente</a></li>
            <li><a class="dropdown-item" href="frmFactura.aspx">Realizar Venta</a></li>
              <li><a class="dropdown-item" href="frmFactura.aspx">Formas de Pago</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Ver Ventas Realizadas</a></li>
          </ul>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="administrativo" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Administrar
          </a>
          <ul class="dropdown-menu" aria-labelledby="administrativo">
            <li><a class="dropdown-item" href="#">Empleados</a></li>
               <li><a class="dropdown-item" href="#">Puestos</a></li>
            <li><a class="dropdown-item" href="frmFactura.aspx">Usuarios</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Sucursales</a></li>
               <li><a class="dropdown-item" href="#">Proveedores</a></li>
          </ul>
        </li>
          <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="combustibles" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Combustibles
          </a>
          <ul class="dropdown-menu" aria-labelledby="combustibles">
            <li><a class="dropdown-item" href="#">Tipos De Combustible</a></li>
               <li><a class="dropdown-item" href="#">Abastecimiento</a></li>
            <li><a class="dropdown-item" href="frmFactura.aspx">Bombas De Gasolina</a></li>
            <li><hr class="dropdown-divider"></li>
           
          </ul>
        </li>
      
    </div>
  </div>
</nav>
    
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
   
    
    
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
