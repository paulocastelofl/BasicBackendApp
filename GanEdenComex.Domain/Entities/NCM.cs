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
        //public Capitulo capitulo { get; set; } //classe desconhecida
        //public Posicao posicao { get; set; } //classe desconhecida
        public double? VlIi { get; set; }
        public double? VlIiMercosul { get; set; }
        public double? VlIpi { get; set; }
        public double? VlPis { get; set; }
        public double? VlCofins { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        //public List<SxTratamentoAdministrativo> sxTratamentoAdministrativo { get; set; } //lista de tabela auxiliar
        //public List<object> sxNve { get; set; } //lista auxiliar desconhecida
        //public List<SxExTarifario> sxExTarifarios { get; set; } //lista de uma tabela auxiliar
        //public List<object> detalhes { get; set; } //lista auxiliar desconhecida
        //public object atributos { get; set; } //objeto desconhecido
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        //public ComplementosExportacao complementosExportacao { get; set; } //tabela desconhecida
    }
}
