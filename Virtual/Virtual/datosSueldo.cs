using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using procesos;
using Modelo.clases;

namespace Virtual
{
    public class datosSueldo
    {
        public string SueldoEstados;
        public void Generar()
        {
            using (var db = new ProyectoContext())
            {
                Configuracion config = db.empresas
                    .Single(est => est.MinHorasExtra == 12);
                //sueldo de gabriel

                DateTime fecha = new DateTime(2020, 2, 1);

                Empleado empleado = db.empleados
                .Single(est => est.Nombre == "Gabriel Fierro");

                Ingresos totalingre = db.ingresos
                .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                Deducciones totaldedu = db.deducciones
                    .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                float total = totalingre.IngresosTotal - totaldedu.DeduccionesTotal;

                if (totalingre.HorasExtras <= 12)
                {
                    SueldoEstados = "PagoAprobado"; 
                } else
                {
                    SueldoEstados = "PagoPendiente";
                }

                Sueldo sueldoGabriel = totalProc.creaSueldo(db,
                    empleado.EmpleadoId, SueldoEstados, fecha ,total);
                db.totales.Add(sueldoGabriel);

                //sueldo de Maria

                empleado = db.empleados
                .Single(est => est.Nombre == "Maria Garcia");

                totalingre = db.ingresos
                .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                totaldedu = db.deducciones
                    .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                total = totalingre.IngresosTotal - totaldedu.DeduccionesTotal;

                if (totalingre.HorasExtras <= 12)
                {
                    SueldoEstados = "PagoAprobado";
                }
                else
                {
                    SueldoEstados = "PagoPendiente";
                }

                Sueldo sueldoMaria = totalProc.creaSueldo(db,
                    empleado.EmpleadoId, SueldoEstados, fecha, total);
                db.totales.Add(sueldoMaria);

                //sueldo de daniela

                empleado = db.empleados
                .Single(est => est.Nombre == "Daniela Guevara");

                totalingre = db.ingresos
                .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                totaldedu = db.deducciones
                    .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                total = totalingre.IngresosTotal - totaldedu.DeduccionesTotal;

                if (totalingre.HorasExtras <= 12)
                {
                    SueldoEstados = "PagoAprobado";
                }
                else
                {
                    SueldoEstados = "PagoPendiente";
                }

                Sueldo sueldoDaniela = totalProc.creaSueldo(db,
                    empleado.EmpleadoId, SueldoEstados, fecha, total);
                db.totales.Add(sueldoDaniela);

                //sueldo de Kevin

                empleado = db.empleados
                .Single(est => est.Nombre == "Kevin Masabanda");

                totalingre = db.ingresos
                .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                totaldedu = db.deducciones
                    .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                total = totalingre.IngresosTotal - totaldedu.DeduccionesTotal;

                if (totalingre.HorasExtras <= 12)
                {
                    SueldoEstados = "PagoAprobado";
                }
                else
                {
                    SueldoEstados = "PagoPendiente";
                }

                Sueldo sueldoKevin = totalProc.creaSueldo(db,
                    empleado.EmpleadoId, SueldoEstados, fecha, total);
                db.totales.Add(sueldoKevin);

                //sueldo de karen

                empleado = db.empleados
                .Single(est => est.Nombre == "Karen Valladares");

                totalingre = db.ingresos
                .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                totaldedu = db.deducciones
                    .Single(est => est.EmpleadoId == empleado.EmpleadoId);

                total = totalingre.IngresosTotal - totaldedu.DeduccionesTotal;

                if (totalingre.HorasExtras <= 12)
                {
                    SueldoEstados = "PagoAprobado";
                }
                else
                {
                    SueldoEstados = "PagoPendiente";
                }

                Sueldo sueldokaren = totalProc.creaSueldo(db,
                    empleado.EmpleadoId, SueldoEstados, fecha, total);
                db.totales.Add(sueldokaren);
                db.SaveChanges();
            }

        }
    }
}
