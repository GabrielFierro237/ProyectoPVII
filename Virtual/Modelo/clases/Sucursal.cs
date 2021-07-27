using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Sucursal : IDBEntity
    {
        [Key]
        public int SucursalId { get; set; }
        [ConcurrencyCheck]
        public String Ciudad { get; set; }
        [ConcurrencyCheck]
        public String Direccion { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
