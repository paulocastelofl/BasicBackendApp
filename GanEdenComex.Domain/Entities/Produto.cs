using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Produto: BaseEntity
    {
        public string? Nome_Produto { get; set; }
        public int? Quantidade { get; set; }
        public double? Peso { get; set; }
        public string? Tipo_De_Emabalagem { get; set;}
        [ForeignKey("Fabricante")]
        public int? IdFabricante { get; set; }
        public virtual Fabricante? Fabricante { get; set; }

    }
}
