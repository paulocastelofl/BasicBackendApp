using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Tributacao: BaseEntityAux
    {
        public double aliquotaMva { get; set; }
        public double aliquotaReducao { get; set; }
        public double aliquotaIcms { get; set; }
        public double coeficienteNormal { get; set; }
        public double coeficienteLei2826 { get; set; }
    }
}
