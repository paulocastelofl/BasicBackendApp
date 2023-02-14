using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class BaseEntityAux: BaseEntity
    {
        public string? nome { get; set; }
        public string? codigo { get; set; }
        public DateTime? dtModificacao { get; set; }
    }
}
