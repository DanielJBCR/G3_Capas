using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Modelo;


namespace CapaDatos.Clases
{
    public class MetodosEmpleado
    {

        G3_SEMANA2Entities db = new G3_SEMANA2Entities();

        /* Este medoto se encarga de guardar los datos en la BD */

        public bool Guardar(empleado emp)
        {
            db.empleado.Add(emp);
            db.SaveChanges();
            return true;
        }

    }
}
