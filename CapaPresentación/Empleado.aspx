<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="CapaPresentación.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server">
        <div class="input-group mb-3">
           Código <asp:TextBox ID="txtCodigo" runat="server" class="form-control mt-2"></asp:TextBox><br />
            Nombre<asp:TextBox ID="txtNombre" runat="server" class="form-control mt-2"></asp:TextBox><br />
            Horas<asp:TextBox ID="txtHoras" runat="server" class="form-control mt-2"></asp:TextBox><br />
            Salario Hora<asp:TextBox ID="txtSalHora" runat="server" class="form-control mt-2"></asp:TextBox><br />
            Salario Bruto<asp:TextBox ID="txtSalBruto" runat="server" class="form-control mt-2"></asp:TextBox><br />
            <asp:Button ID="bt_Guardar" runat="server" Text="Guardar" OnClick="bt_Guardar_Click"  class="btn-primary mt-4"/><br />
        
        
        
        </div>
    </form>
</body>
</html>
