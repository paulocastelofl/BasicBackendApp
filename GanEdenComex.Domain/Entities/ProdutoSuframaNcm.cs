using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GanEdenComex.Domain.Entities
{
    public class ProdutoSuframaNcm : BaseEntityAux
    {
        public bool ativo { get; set; }
        [ForeignKey("ProdutoSuframa")]
        public int? IdProdutoSuframa { get; set; }
        public virtual ProdutoSuframa? ProdutoSuframa { get; set; }
        [ForeignKey("Ncm")]
        public int? IdNcm { get; set; }
        public virtual Ncm? Ncm { get; set; }
        [ForeignKey("TipoProduto")]
        public int? IdTipoProduto { get; set; }
        public virtual TipoProduto? TipoProduto { get; set; }
    }
}
