using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Item: BaseEntity
    {
        public string? ncm { get; set; }
        public string? naladi { get; set; }
        public string? descricao { get; set; }
        public string? partNumber { get; set; }
        public string? codigoInterno { get; set; }
        public string? unidadeOrganizacional { get; set; }
        public string? descricaoItemNfe { get; set; }
        public string? unidade { get; set; }
        public string? detalheNcm { get; set; }
        public string? produtoSuframa { get; set; }
        public double? aliquotaIi { get; set; }
        public double? aliquotaIpi { get; set; }
        public double? aliquotaPis { get; set; }
        public double? aliquotaCofins { get; set; }
        public DateTime? dtModificacao { get; set; } = DateTime.Now;

        [ForeignKey("Fornecedor")]
        public int? IdFornecedor { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }

        /*public string? PartNumber { get; set; }
        public string? partNumberInterno { get; set; }
        public string? DescricaoDetalhada { get; set;}
        [ForeignKey("Fornecedor")]
        public int? IdFornecedor { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
        
        [ForeignKey("Ncm")]
        public int? IdNCM { get; set; }
        public virtual Ncm? Ncm { get; set; }
        [ForeignKey("Unidade")]
        public int? IdUnidade { get; set; }
        public virtual Unidade? unidade { get; set; }
        public string? DescricaoNFE { get; set; }
        public string? detalheNcm { get; set; }
        public string? ProdutoSuframa { get; set; }
        public string? DescricaoProdutoSuframa { get; set; }
        public string? tipoProduto { get; set; }
        public string? tratamentoAdministrativo { get; set; }
        public double? vlCra { get; set; }
        public double? AliquotaII {get; set; }
        public double? AliquotaIPI { get; set; }
        public double? AliquotaPIS { get; set; }
        public double? AliquotaCOFINS { get; set; }
        public string? UnidadeOrganizacional { get; set; }
        public DateTime? dtModificacao { get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        [ForeignKey("Naladi")]
        public int? IdNaladi { get; set; }
        public virtual Naladi? naladi { get; set; }
        [ForeignKey("ExTarifario")]
        public int? IdExTarifario { get; set; }
        public virtual ExTarifario? extarifario { get; set; }
        [ForeignKey("ExTIPI")]
        public int? IdExTIPI { get; set; }
        public virtual ExTIPI? extipi { get; set; }*/

    }
}
