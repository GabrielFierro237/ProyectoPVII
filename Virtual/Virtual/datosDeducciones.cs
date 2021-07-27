using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.clases;
using procesos;
using System.Threading.Tasks;
using Virtual;

namespace Virtual
{
    public class datosDeducciones
    {
        public void Generar()
        {
            using (var db = new ProyectoContext())
            {
                //deducciones de gabriel
                Empleado empleado = db.empleados
                .Single(est => est.Nombre == "Gabriel Fierro");
                float aportepersonal = 187f;
                float multas = 0f;
                float anticipos = 500f;
                float comisariato = 0f;
                float total = 687f;
                Deducciones deduccionGabriel = deduccionesProc.creaDeducciones(db,
                    empleado.EmpleadoId, aportepersonal, multas, anticipos, comisariato, total);
                db.deducciones.Add(deduccionGabriel);

                //deducciones de maria
                empleado = db.empleados
                .Single(est => est.Nombre == "Maria Garcia");
                aportepersonal = 112.2f;
                multas = 60f;
                anticipos = 0f;
                comisariato = 0f;
                total = 172.2f;
                Deducciones deduccionMaria = deduccionesProc.creaDeducciones(db,
                    empleado.EmpleadoId, aportepersonal, multas, anticipos, comisariato, total);
                db.deducciones.Add(deduccionMaria);

                //deducciones de daniela
                empleado = db.empleados
                .Single(est => est.Nombre == "Daniela Guevara");
                aportepersonal = 57.85f;
                multas = 30.94f;
                anticipos = 300f;
                comisariato = 0f;
                total = 388.79f;
                Deducciones deduccionDaniela = deduccionesProc.creaDeducciones(db,
                    empleado.EmpleadoId, aportepersonal, multas, anticipos, comisariato, total);
                db.deducciones.Add(deduccionDaniela);

                //deducciones de kevin
                empleado = db.empleados
                .Single(est => est.Nombre == "Kevin Masabanda");
                aportepersonal = 65.45f;
                multas = 0f;
                anticipos = 100f;
                comisariato = 200f;
                total = 365.45f;
                Deducciones deduccionKevin = deduccionesProc.creaDeducciones(db,
                    empleado.EmpleadoId, aportepersonal, multas, anticipos, comisariato, total);
                db.deducciones.Add(deduccionKevin);

                //deducciones de karen
                empleado = db.empleados
                .Single(est => est.Nombre == "Karen Valladares");
                aportepersonal = 99.58f;
                multas = 0f;
                anticipos = 0f;
                comisariato = 75f;
                total = 174.58f;
                Deducciones deduccionkaren = deduccionesProc.creaDeducciones(db,
                    empleado.EmpleadoId, aportepersonal, multas, anticipos, comisariato, total);
                db.deducciones.Add(deduccionkaren);
                db.SaveChanges();
            }

        }
    }
}
