using Microsoft.EntityFrameworkCore;
using Modelo.clases;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using Virtual;

namespace procesos
{
    public class ingresosProc
    {
        public ProyectoContext _context;

        public ingresosProc(ProyectoContext context)
        {
            _context = context;
        }
        static public Ingresos creaIngreso(
            ProyectoContext context,
            int emp, float sueldo, int horasextra, float comisiones, float total)
        {
            
            Empleado empleado = context.empleados
                .Single(est => est.EmpleadoId == emp);

            
            Ingresos ingreso = new Ingresos()
            {
                Empleado = empleado,
                Sueldo = sueldo,
                HorasExtras = horasextra,
                Comisiones = comisiones,
                IngresosTotal = total
            };

            return ingreso;
        }
        public float ingresot(Ingresos ingre)
        {
            return ingre.ingresot();
        }
    }
}
