using System;
using System.Collections.Generic;
using Modelo.clases;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual;

namespace procesos
{
    public class deduccionesProc
    {
        public ProyectoContext _context;

        public deduccionesProc(ProyectoContext context)
        {
            _context = context;
        }
        static public Deducciones creaDeducciones(
            ProyectoContext context,
            int emp, float aportepersonal, float multas, float anticipos, float comisariato, float total)
        {
            
            Empleado empleado = context.empleados
                .Single(est => est.EmpleadoId == emp);

            
            Deducciones deduccion = new Deducciones()
            {
                Empleado = empleado,
                AportePersonal = aportepersonal,
                Multas = multas,
                Anticipos = anticipos,
                Comisariato = comisariato,
                DeduccionesTotal = total,
            };

            return deduccion;
        }
    }
}
