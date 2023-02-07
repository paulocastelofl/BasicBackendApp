using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class CertificadoDigital: BaseEntity
    {
        public string? Arquivo_CertificadoDigital { get; set; }
        public string? Senha_CerficadoDigital {get; set; }
        public DateTime? DT_Vencimento_CertificadoDigital {get; set; }
    }
}
