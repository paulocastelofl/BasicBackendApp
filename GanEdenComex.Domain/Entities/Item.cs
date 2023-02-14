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
        public string? PartNumber { get; set; }
        public int? CodigoInterno { get; set; }
        public string? UnidadeOrganizacional { get; set; }
        public string? DescricaoDetalhada { get; set;}
         public string? DescricaoNFE { get; set;}
        [ForeignKey("Fornecedor")]
        public int? IdFornecedor { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
        [ForeignKey("NCM")]
        public int? IdNCM { get; set; }
        public virtual NCM? NCM { get; set; }
        public int? NALADI { get; set; }
        public string? DescricaoNALADI { get; set; }
        public string? CodigoExTarifario { get; set; }
        public string? OrgaoExTarifario { get; set; }
        public string? TipoExTarifario { get; set; }
        public string? AtoExTarifario { get; set; }
        public string? AnoExTarifario { get; set; }
        public string? CodigoExTIPI { get; set; }
        public string? OrgaoExTIPI { get; set; }
        public string? TipoExTIPI { get; set; }
        public string? AtoExTIPI { get; set; }
        public string? AnoExTIPI { get; set; }
        public string? Destaque { get; set; }
        public int? ProdutoSuframa { get; set; }
        public string? DescricaoProdutoSuframa { get; set; }
        public string? TipoProdutoSuframa { get; set; }
        public string? DetalheProdutoSuframa { get; set; }
        public double? AliquotaII {get; set; }
        public double? AliquotaIPI { get; set; }
        public double? AliquotaPIS { get; set; }
        public double? AliquotaCOFINS { get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        /*
        [ForeignKey("Fornecedor")]
        public int? IdFornecedor { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
        */
    }
}
