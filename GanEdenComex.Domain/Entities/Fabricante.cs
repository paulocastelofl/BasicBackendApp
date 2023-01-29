using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Fabricante: BaseEntity
    {
        public string? Nome_Fabricante { get; set; }
    }
}
