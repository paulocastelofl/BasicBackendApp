using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Incoterms: BaseEntityAux
    {
        public bool? freteEmbutido { get; set; }
        public bool?  seguroEmbutido { get; set; }
    }
}
