using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Sueldo : IDBEntity
    {
        [Key]
        public int TotalId { get; set; }
        [ConcurrencyCheck]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        [ConcurrencyCheck]
        public DateTime Fecha { get; set; }
        [ConcurrencyCheck]
        public string Estado { get; set; }
        [ConcurrencyCheck]
        public float SueldoTotal { get; set; }

    }
}
