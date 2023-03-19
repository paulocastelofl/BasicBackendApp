using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.DTO
{
    public class TributacaoDTO
    {
        public string? nome { get; set; }
        public string? codigo { get; set; }
        public DateTime? dtModificacao { get; set; }
        public bool ativo { get; set; }
        public double aliquotaMva { get; set; }
        public double aliquotaReducao { get; set; }
        public double aliquotaIcms { get; set; }
        public double coeficienteNormal { get; set; }
        public double coeficienteLei2826 { get; set; }
    }
}
