using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Ncm: BaseEntity
    {
        public DateTime? DtModificacao { get; set; }
        [ForeignKey("Unidade")]
        public int? IdUnidade { get; set; }
        public virtual Unidade? Unidade { get; set; }
        [ForeignKey("Capitulo")]
        public int? IdCapitulo { get; set; }
        public virtual Capitulo? Capitulo { get; set; }
        public double? VlIi { get; set; }
        public double? VlIiMercosul { get; set; }
        public double? VlIpi { get; set; }
        public double? VlPis { get; set; }
        public double? VlCofins { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
    }
}
