using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual;
using Modelo.clases;

namespace procesos
{
    public class totalProc
    {
        public ProyectoContext _context;

        public totalProc(ProyectoContext context)
        {
            _context = context;
        }
        static public Sueldo creaSueldo(
            ProyectoContext context,
            int emp, string estado, DateTime fecha,float total)
        {
            
            Empleado empleado = context.empleados
                .Single(est => est.EmpleadoId == emp);

            
            Sueldo sueldo = new Sueldo()
            {
                Empleado = empleado,
                Estado = estado,
                Fecha = fecha,
                SueldoTotal = total
            };

            return sueldo;
        }
    }
}
