using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class NCM: BaseEntity
    {
        public DateTime? dtModificacao { get; set; }
        [ForeignKey("Unidade")]
        public int? IdUnidade { get; set; }
        public virtual Unidade? unidade { get; set; }
        //public Capitulo capitulo { get; set; }
        //public Posicao posicao { get; set; }
        public double? vlIi { get; set; }
        public double? vlIiMercosul { get; set; }
        public double? vlIpi { get; set; }
        public double? vlPis { get; set; }
        public double? vlCofins { get; set; }
        public DateTime? dtAtualizacao { get; set; }
        //public List<SxTratamentoAdministrativo> sxTratamentoAdministrativo { get; set; }
        //public List<object> sxNve { get; set; }
        //public List<SxExTarifario> sxExTarifarios { get; set; }
        //public List<object> detalhes { get; set; }
        //public object atributos { get; set; }
        public string? nome { get; set; }
        public string? codigo { get; set; }
        //public ComplementosExportacao complementosExportacao { get; set; }
    }
}
