using System.Collections.Generic;
using Modelo;

namespace Escenarios
{
    public class Escenario
    {
        public enum ListaTipo
        {
            Empleados, Configuracion, Sucursal, Ingresos, Deducciones
        };
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;

        public Escenario()
        {
            datos = new();
        }
    }
}
