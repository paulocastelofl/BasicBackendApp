using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class NCM: BaseEntity
    {
        public string? Codigo_NCM { get; set; }
        public string? Descricao { get; set; }
        public string? Descricao_Concatenada { get; set; }
        public DateTime? Data_Inicio { get; set; }
        public DateTime? Data_Fim {get; set; }
        public string? Ato_Legal {get; set; }
        public string? Numero {get; set; }
        public string? Ano {get; set; }
    }
}
