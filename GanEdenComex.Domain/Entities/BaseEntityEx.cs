using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class BaseEntityEx: BaseEntity
    {
        public string? codigo { get; set; }
        public string? orgao { get; set; }
        public string? ato { get; set; }
        public string? ano { get; set; }
        public DateTime? dtModificacao { get; set; }
    }
}
