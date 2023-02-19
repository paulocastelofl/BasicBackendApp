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
        public DateTime? dtModificacao { get; set; }
        [ForeignKey("Unidade")]
        public int? IdUnidade { get; set; }
        public virtual Unidade? unidade { get; set; }
        //public Capitulo capitulo { get; set; } //classe desconhecida
        //public Posicao posicao { get; set; } //classe desconhecida
        public double? vlIi { get; set; }
        public double? vlIiMercosul { get; set; }
        public double? vlIpi { get; set; }
        public double? vlPis { get; set; }
        public double? vlCofins { get; set; }
        public DateTime? dtAtualizacao { get; set; }
        //public List<SxTratamentoAdministrativo> sxTratamentoAdministrativo { get; set; } //lista de tabela auxiliar
        //public List<object> sxNve { get; set; } //lista auxiliar desconhecida
        //public List<SxExTarifario> sxExTarifarios { get; set; } //lista de uma tabela auxiliar
        //public List<object> detalhes { get; set; } //lista auxiliar desconhecida
        //public object atributos { get; set; } //objeto desconhecido
        public string? nome { get; set; }
        public string? codigo { get; set; }
        //public ComplementosExportacao complementosExportacao { get; set; } //tabela desconhecida
    }
}
