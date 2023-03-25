using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class ItemFatura: BaseEntity
    {
        [ForeignKey("Item")]
        public int? IdItem { get; set; }
        public virtual Item? Item { get; set; }
        [ForeignKey("Fatura")]
        public int? IdFatura { get; set; }
        public virtual Fatura? Fatura { get; set; }
    }
}