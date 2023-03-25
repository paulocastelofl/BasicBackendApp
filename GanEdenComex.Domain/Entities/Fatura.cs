using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Fatura: BaseEntity
    {
        public DateTime? dtModificacao { get; set; }
        public DateTime? dtEmissao { get; set; }
        public string? numeroFatura { get; set;}
        public string? localCondicao { get; set; }
        [ForeignKey("Fornecedor")]
        public int? IdFornecedor { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
        [ForeignKey("Moeda")]
        public int? IdMoeda { get; set; }
        [ForeignKey("Incoterms")]
        public int? IdIncoterms { get; set; }
        public virtual Incoterms? Incoterms { get; set; }
        [ForeignKey("Moeda")]
        public int? IdMoedaFrete { get; set; }
        [ForeignKey("Moeda")]
        public int? IdMoedaSeguro { get; set; }
        [ForeignKey("ItemFatura")]
        public int? IdItemFatura { get; set; }
        public virtual ICollection<ItemFatura>? ItensFaturas { get; set; }
        [ForeignKey("ModalidadePagamento")]
        public int? IdModalidadePagamento { get; set; }
        public virtual ModalidadePagamento? ModalidadePagamento { get; set; }
        [ForeignKey("CoberturaCambial")]
        public int? IdCoberturaCambial { get; set; }
        public virtual CoberturaCambial? CoberturaCambial { get; set; }
        [ForeignKey("FundamentoLegal")]
        public int? IdFundamentoLegal { get; set; }
        public virtual FundamentoLegal? FundamentoLegal { get; set; }
        public int? numDiasPagamento { get; set; }
        public double? valorTotal { get; set; }
        public double? pesoLiquido { get; set; }
        public string? tipoVinculoFornecedor { get; set; }
        [ForeignKey("ProcessoImportacao")]
        public int? IdProcessoImportacao { get; set; }
        public virtual ProcessoImportacao? ProcessoImportacao { get; set; }
    }
}