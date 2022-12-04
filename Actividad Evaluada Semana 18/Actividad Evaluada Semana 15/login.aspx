<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Actividad_Evaluada_Semana_15._default1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Home</title>
    <link rel ="stylesheet " href="style.css" />
    <link rel="shorcut icon" href="images/icono.ico"/>
  <script type="text/javascript">
  </script>
</head>
<body>
<nav>
  <div class="logo">
      <h4>HOME</h4>
  </div>
  <ul class="nav-links"> 
      <a href="default.aspx">Home</a>
  </ul>
  <div class="burger">
    <div class="line1"></div>
    <div class="line2"></div>
    <div class="line3"></div>
  </div>
</nav>
    <br><br><br>
    <div class ="log">
        <center><h3>Iniciar sesión</h3></center>
    <form id="form1" runat="server">

    <center>
    Usuario:
    <asp:TextBox id="usuario" Text="" runat="server" />
    <br /><br />

    Contraseña:
    <asp:TextBox id="password" TextMode="Password" runat="server" />
    <br /><br />

    <asp:Button id="enviar" Text="Ingresar" runat="server" OnClick="enviar_Click" />

    <asp:Label id="Label1" Text="" runat="server" />

    </center>

    </form>
   </div>
</body>
</html>