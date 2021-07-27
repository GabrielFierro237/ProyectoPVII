using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Modelo.clases;
using static Escenarios.Escenario;

namespace Virtual
{
    public class EscenarioControl
    {
        public void Grabar(IEscenario escenario) {
            var datos = escenario.carga();
            using (var db = new ProyectoContext()) {
                //Reiniciamos la Base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                //Insertamos los datos
                db.empleados.AddRange((List<Empleado>) datos[ListaTipo.Empleados]);
                db.empresas.AddRange((List<Configuracion>)datos[ListaTipo.Configuracion]);
                db.sucursales.AddRange((List<Sucursal>)datos[ListaTipo.Sucursal]);
                
                //Genera la persistencia
                db.SaveChanges();
            }
        }
    }
}
