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
        public int? IdNCM {get; set; }
        public virtual NCM? NCM {get; set; }
        //NALADI ?
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
