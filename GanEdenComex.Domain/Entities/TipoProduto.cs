using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GanEdenComex.Domain.Entities
{
    public class TipoProduto: BaseEntityAux
    {
        public bool? ativo { get; set; }
        [ForeignKey("ProdutoSuframa")]
        public int? IdProdutoSuframa { get; set; }
    }
}
