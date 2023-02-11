using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class AtoLegal: BaseEntity
    {
        public int? Numero { get; set; }
        public string? Tipo { get; set; }
        public string? Orgao { get; set; }
        public string? Descricao { get; set;}
        public bool? Geral { get; set; }
        public bool? Ativo { get; set; }
        public bool? VincularProcessos {get; set; }
        public string? RegimeIPI {get; set; }
        public string? FundamentoII {get; set; }
        public string? RegimePISCOFINS {get; set; }
        public string? FundamentoPISCOFINS {get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}