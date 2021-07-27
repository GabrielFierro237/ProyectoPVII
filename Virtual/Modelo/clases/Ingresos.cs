using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Ingresos : IDBEntity
    {
        [Key]
        public int IngresoId { get; set; }
        [ConcurrencyCheck]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        [ConcurrencyCheck]
        public float Sueldo { get; set; }
        [ConcurrencyCheck]
        public int HorasExtras { get; set; }
        [ConcurrencyCheck]
        public float Comisiones { get; set; }
        [ConcurrencyCheck]
        public float IngresosTotal { get; set; }

        public float ingresot()
        {
            // Cálculo
            float suma = 0;
            suma += Sueldo;
            suma += ((Sueldo/30)/8)*1.5f*HorasExtras;
            suma += Comisiones;
            suma = MathF.Round(suma, 2);
            return suma;
        }
    }
}
