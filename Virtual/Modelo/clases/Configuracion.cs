using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.clases
{
    public class Configuracion : IDBEntity
    {
        [Key]
        public int ConfiguracionId { get; set; }
        [ConcurrencyCheck]
        public String NombreEmpresa { get; set; }
        [ConcurrencyCheck]
        public int MinHorasExtra { get; set; }
    }
}
