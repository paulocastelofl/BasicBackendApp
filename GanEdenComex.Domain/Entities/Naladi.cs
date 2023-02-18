using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Naladi: BaseEntity
    {
        public string? codigo { get; set; }
        public string? nome { get; set; }
        public int? ordem { get; set; }
        public DateTime? dtModificacao { get; set; }
    }
}
