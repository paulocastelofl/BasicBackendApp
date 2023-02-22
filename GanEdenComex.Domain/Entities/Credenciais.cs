using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Credenciais: BaseEntity
    {
        public string? portal { get; set; }
        public string? login { get; set; }
        public string? senha { get; set; }
    }
}
