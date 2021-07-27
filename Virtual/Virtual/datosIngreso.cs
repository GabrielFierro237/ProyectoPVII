using Modelo.clases;
using System;
using System.Collections.Generic;
using procesos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class datosIngreso
    {
        public void Generar()
        {
            using (var db = new ProyectoContext())
            {

                //ingresos de gabriel
                Empleado empleado = db.empleados
                .Single(est => est.Nombre == "Gabriel Fierro");

                float sueldo = 2000f;
                int horasextra = 0;
                float comisiones = 0f;
                float total = 2000f;
                Ingresos ingresosGabriel = ingresosProc.creaIngreso(db,
                    empleado.EmpleadoId, sueldo, horasextra, comisiones, total );
                db.ingresos.Add(ingresosGabriel);

                //ingresos de maria
                empleado = db.empleados
                .Single(est => est.Nombre == "Maria Garcia");

                sueldo = 1200f;
                horasextra = 0;
                comisiones = 0f;
                total = 1200f;
                Ingresos ingresosMaria = ingresosProc.creaIngreso(db,
                    empleado.EmpleadoId, sueldo, horasextra, comisiones, total);
                db.ingresos.Add(ingresosMaria);

                //ingresos de daniela
                empleado = db.empleados
                .Single(est => est.Nombre == "Daniela Guevara");
                sueldo = 600f;
                horasextra = 5;
                comisiones = 0f;
                total = 618.75f;
                Ingresos ingresosDaniela = ingresosProc.creaIngreso(db,
                    empleado.EmpleadoId, sueldo, horasextra, comisiones, total);
                db.ingresos.Add(ingresosDaniela);

                // ingresos de daniela
                empleado = db.empleados
                .Single(est => est.Nombre == "Kevin Masabanda");
                sueldo = 700f;
                horasextra = 0;
                comisiones = 0f;
                total = 700f;
                Ingresos ingresosKevin = ingresosProc.creaIngreso(db,
                    empleado.EmpleadoId, sueldo, horasextra, comisiones, total);
                db.ingresos.Add(ingresosKevin);

                // ingresos de daniela
                empleado = db.empleados
                .Single(est => est.Nombre == "Karen Valladares");
                sueldo = 800f;
                horasextra = 10;
                comisiones = 215f;
                total = 1065f;
                Ingresos ingresosKaren = ingresosProc.creaIngreso(db,
                    empleado.EmpleadoId, sueldo, horasextra, comisiones, total);
                db.ingresos.Add(ingresosKaren);
                db.SaveChanges();
            }
            
        }
    }
}
