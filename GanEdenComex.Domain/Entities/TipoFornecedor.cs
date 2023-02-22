using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GanEdenComex.Domain.Entities
{
    public class TipoFornecedor: BaseEntity
    {
        [ForeignKey("Fornecedor")]
        public int? IdEmpresa { get; set; }
        public virtual Fornecedor? Fornecedor { get; set; }
        public bool AgenteDeCarga { get; set; }
        public bool CIAdeTransporte { get; set; }
        public bool DespachanteAduaneiro { get; set; }
        public bool Representante { get; set; }
    }
}
