<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="CapaPresentación.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
           Código <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox><br />
            Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            Horas<asp:TextBox ID="txtHoras" runat="server"></asp:TextBox><br />
            Salario Hora<asp:TextBox ID="txtSalHora" runat="server"></asp:TextBox><br />
            Salario Bruto<asp:TextBox ID="txtSalBruto" runat="server"></asp:TextBox><br />
            <asp:Button ID="bt_Guardar" runat="server" Text="Guardar" OnClick="bt_Guardar_Click" /><br />
        
        
        
        </div>
    </form>
</body>
</html>
