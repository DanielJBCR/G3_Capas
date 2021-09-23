using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;
using CapaDatos.Clases;


namespace CapaLogica
{
    public class MetodosLogica
    {

        MetodosEmpleado met = new MetodosEmpleado();


        public bool Guardar(EntidadEmpleado ent)
        {
            /* Instanciamos la entidad empleados que esta en CapaDatos¨*/
            empleado tblEmp = new empleado();

            tblEmp.codigo_empleado = ent.codigo_empleado;
            tblEmp.Nombre = ent.Nombre;
            tblEmp.Horas_laboradas = ent.Horas_laboradas;
            tblEmp.Salario_Hora = ent.Salario_Hora;
            tblEmp.Salario_Bruto = ent.Salario_Bruto;

            return met.Guardar(tblEmp);
        }


    }
}
