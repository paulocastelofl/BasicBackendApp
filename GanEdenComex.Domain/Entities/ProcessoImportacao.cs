using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class ProcessoImportacao: BaseEntity
    {
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        public int? Despachante {get; set; } //chave estrangeira p/ Empresa
        public int? DespachantePonta { get; set; } //chave estrangeira p/ Empresa
        public string? Codigo { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtModificacao { get; set; }
        public DateTime? DtUltimoEvento { get; set; }
        public string? UltimoEvento { get; set; }
        public string? TipoDeDeclaracao { get; set; }
        [ForeignKey("Pais")]
        public int? IdPais { get; set; }
        public virtual Pais? Pais { get; set; }
        [ForeignKey("Modal")]
        public int? IdModal { get; set; } //chave estrangeira p/ Modal
        public virtual Modal? Modal { get; set; }
        [ForeignKey("Urf")]
        public int? IDUrfdeChegada { get; set; } //chave estrangeira p/ Urf
        public virtual Urf? Urf { get; set; }
        [ForeignKey("Urf")]
        public int? IdUrfdeDespacho { get; set; } //chave estrangeira p/ Urf
        public string? TipoDeConsignatario { get; set; }
        public string? ModalidadeDeDespacho { get; set; }
        public bool? OperacaoFundap { get; set; }
        public bool? ProcessoCritico { get; set; }
        public string? CentroDeCusto { get; set; }
        public DateTime? NecessidadeImportador { get; set; }
        //public string? AnalistaImportador { get; set; }
        //public string? AnalistaDespachante { get; set; }
    }
}
