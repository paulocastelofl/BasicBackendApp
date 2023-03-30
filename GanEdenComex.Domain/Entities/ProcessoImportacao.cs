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

        [ForeignKey("DespanchanteEmpresa")]
        public int? IdDespanchante { get; set; }
        public virtual Empresa? DespanchanteEmpresa { get; set; }

        [ForeignKey("DespachantePontaEmpresa")]
        public int? IdDespachantePonta { get; set; }
        public virtual Empresa? DespachantePontaEmpresa { get; set; }
        public string? Codigo { get; set; }
        public string? CentroDeCusto { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtModificacao { get; set; }
        public DateTime? DtUltimoEvento { get; set; }
        public string? UltimoEvento { get; set; }
        [ForeignKey("TipoDeclaracao")]
        public int? IdTipoDeDeclaracao { get; set; }
        public virtual TipoDeclaracao? TipoDeclaracao { get; set; }
        [ForeignKey("Pais")]
        public int? IdPais { get; set; }
        public virtual Pais? Pais { get; set; }
        [ForeignKey("Modal")]
        public int? IdModal { get; set; } //chave estrangeira p/ Modal
        public virtual Modal? Modal { get; set; }
        [ForeignKey("UrfdeChegada")]
        public int? IdUrfdeChegada { get; set; } //chave estrangeira p/ Urf
        public virtual Urf? UrfdeChegada { get; set; }

        [ForeignKey("UrfdeDespacho")]
        public int? IdUrfdeDespacho { get; set; } //chave estrangeira p/ Urf
        public virtual Urf? UrfdeDespacho { get; set; }

        public string? TipoDeConsignatario { get; set; }
        public string? ModalidadeDeDespacho { get; set; }
        public DateTime? NecessidadeImportador { get; set; }
        [ForeignKey("User")]
        public int? IdAnalistaImportador { get; set; }
        [ForeignKey("User")]
        public int? IdAnalistaDespachante { get; set; }
        public bool? OperacaoFundap { get; set; }
        public bool? ProcessoCritico { get; set; }
        public string? InformacoesAdicionais { get; set; }
        /*
        [ForeignKey("Fatura")]
        public int? IdFatura { get; set; }
        public virtual Fatura? Fatura { get; set; }
        [ForeignKey("Packinglist")]
        public int? IdPackinglist { get; set; }
        public virtual Packinglist? Packinglist { get; set; }
        [ForeignKey("Conhecimento")]
        public int? IdConhecimento { get; set; }
        public virtual Conhecimento? Conhecimento { get; set; }
        */
        
    }
}
