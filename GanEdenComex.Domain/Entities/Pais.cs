using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Pais: BaseEntity
    {
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public int? Ordem { get; set; }
        public DateTime? DtModificacao { get; set; }
        public string? CdNfe { get; set; }
        public string? Iso3166 { get; set; }
        public string? Iso3166_3 { get; set; }
    }
}
