using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Empleado : IDBEntity
    {
        [Key]
        public int EmpleadoId { get; set; }
        [ConcurrencyCheck]
        public String Nombre { get; set; }
        [ConcurrencyCheck]
        public int Telefono { get; set; }
        [ConcurrencyCheck]
        public String Cargo { get; set; }
        [ConcurrencyCheck]
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
        public Ingresos Ingresos { get; set; }
        public Deducciones Deducciones { get; set; }
        public List<Sueldo> Sueldos { get; set; }
    }
}
