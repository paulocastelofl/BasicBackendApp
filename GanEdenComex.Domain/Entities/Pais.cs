using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Pais: BaseEntity
    {
        public string? Codigo_Pais { get; set; }
        public int? Nome_Pais { get; set; }
    }
}
