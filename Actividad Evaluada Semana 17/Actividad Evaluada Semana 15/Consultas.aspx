<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="Actividad_Evaluada_Semana_15.Consultas1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Consultar</title>
    <link rel ="stylesheet " href="style.css" />
    <link rel="shorcut icon" href="images/icono.ico"/>
  <script type="text/javascript">
  </script>
</head>
<body>
<nav>
  <div class="logo">
      <h4>Consultar</h4>
  </div>
  <ul class="nav-links"> 
      <a href="default.aspx">Home</a>
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
    <div class="log">
            <center><h3>Ver usuarios</h3></center>
    <form id="form3" runat="server">
    <center>

        Consultar:
         <asp:Button id="enviar2" Text="Ver usuarios" runat="server" OnClick="enviar2_Click" /></center>
        <div>
            <asp:ScriptManager id="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel id="UpdatePanel1" UpdateMode="Conditional" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GVConsultar" runat="server"  AutoGenerateColumns="False"  >
                        <Columns>
                            <asp:BoundField HeaderText="Id" DataField="Id"/>
                            <asp:BoundField HeaderText="Codigo" DataField="Codigo"/>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                            <asp:BoundField HeaderText="Usuario" DataField="Usuario"/>
                            <asp:BoundField HeaderText="Contraseña" DataField="Contraseña"/>
                            <asp:BoundField HeaderText="Rango" DataField="Rango"/>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    
        Código:
        <asp:TextBox id="idm" Text="" runat="server" />
        <br /><br />
    
        Nombre:
        <asp:TextBox id="nombrem" Text="" runat="server" />
        <br /><br />

        Usuario:
        <asp:TextBox id="usuariom" Text="" runat="server" />
        <br /><br />

        Contraseña:
        <asp:TextBox id="passwordm" Text="" runat="server" />
        <br /><br />

        Contraseña:
        <asp:TextBox id="rangom" Text="" runat="server" />
        <br /><br />

    </form>
    </div>
</body>
</html>
