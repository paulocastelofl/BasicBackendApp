using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Capitulo: BaseEntityAux
    {
        public double? VlIi { get; set; }
        public double? VlIiMercosul { get; set; }
        public double? VlIpi { get; set; }
        public double? VlPis { get; set; }
        public double? VlCofins { get; set; }
        public DateTime? dtAtualizacao { get; set; }
    }
}
