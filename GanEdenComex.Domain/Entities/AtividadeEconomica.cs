using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class AtividadeEconomica: BaseEntity
    {
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public int? Ordem { get; set; }
        public DateTime? DtModificacao { get; set; }
    }
}
