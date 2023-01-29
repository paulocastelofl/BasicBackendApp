using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class RegistroAcesso: BaseEntity
    {
       [ForeignKey("User")]
       public int? UserId { get; set; }
       public virtual User? User { get; set; }
       public DateTime? Dt_E_Hora_Ultimo_Acesso { get; set; }
       public string? Processo_Ultimo_Acesso { get; set; } 
    }
}
