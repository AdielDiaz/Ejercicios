<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="Actividad_Evaluada_Semana_15.Modificar" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>MODIFICAR</title>
    <link rel ="stylesheet " href="style.css" />
    <link rel="shorcut icon" href="images/icono.ico"/>
  <script type="text/javascript">
  </script>
</head>
<body>
<nav>
  <div class="logo">
      <h4>MODIFICAR REGISTRO</h4>
  </div>
 <ul class="nav-links"> 
      <a href="logout.aspx">Cerrar Sesión</a>
      <a href="Registro.aspx">Registro</a> 
      <a href="Consultas.aspx">Consultar</a>
     
  </ul>
  <div class="burger">
    <div class="line1"></div>
    <div class="line2"></div>
    <div class="line3"></div>
  </div>
</nav>
  <br><br><br>
    
    <div class="reg">
        <center>
                             <h3>Modificar Usuario</h3></center>
    <form id="form5" runat="server">
    <center>
   <br>
      
        Código:
    <asp:TextBox id="idoculto" Text="" runat="server" />
    <br /><br />
    
    Código:
    <asp:TextBox id="idmod" Text="" runat="server" />
    <br /><br />
    
    Nombre:
    <asp:TextBox id="nombremod" Text="" runat="server" />
    <br /><br />
    Usuario:
    <asp:TextBox id="usuariomod" Text="" runat="server" />
    <br /><br />
    Contraseña:
    <asp:TextBox id="passwordmod" Text="" runat="server" />
    <br /><br />
    Rango:
    <asp:DropDownList runat="server" ID="ddlLista2" />
    <br /><br />
    
    <asp:Button id="modificar" Text="Modificar" runat="server" OnClick="modificar_Click" /></center>
        <center><asp:Label id="Label5" Text="" runat="server" /></center>
 
    </form>
    </div>
</body>
</html>