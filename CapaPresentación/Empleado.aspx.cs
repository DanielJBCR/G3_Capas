using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos.Modelo;
using CapaDatos.Clases;
using CapaLogica;

namespace CapaPresentación
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        MetodosLogica logicos = new MetodosLogica();
        EntidadEmpleado entemp = new EntidadEmpleado();




        protected void bt_Guardar_Click(object sender, EventArgs e)
        {
            txtSalBruto.Text = Convert.ToString(Convert.ToUInt32(txtSalHora.Text) * Convert.ToUInt32(txtHoras.Text));
            entemp.codigo_empleado = Convert.ToInt32(txtCodigo.Text);
            entemp.Nombre = txtNombre.Text;
            entemp.Horas_laboradas = Convert.ToInt32(txtHoras.Text);
            entemp.Salario_Hora = Convert.ToInt32(txtSalHora.Text);
            entemp.Salario_Bruto = Convert.ToInt32(txtSalBruto.Text);
            logicos.Guardar(entemp);


        }
    }
}