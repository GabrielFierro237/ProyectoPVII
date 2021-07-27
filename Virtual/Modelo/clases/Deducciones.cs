using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Deducciones : IDBEntity
    {
        [Key]
        public int DeduccionId { get; set; }
        [ConcurrencyCheck]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        [ConcurrencyCheck]
        public float AportePersonal { get; set; }
        [ConcurrencyCheck]
        public float Multas { get; set; }
        [ConcurrencyCheck]
        public float Anticipos { get; set; }
        [ConcurrencyCheck]
        public float Comisariato { get; set; }
        [ConcurrencyCheck]
        public float DeduccionesTotal { get; set; }
    }
}
