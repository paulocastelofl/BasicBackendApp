using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Conta: BaseEntity
    {
        public string? Banco { get; set; }
        public string? Agencia { get; set; }
        public string? Numero { get; set; }
        public string? NomeTitular { get; set;}
        public string? CpfTitular { get; set; }
        public string? RestricaoUso { get; set; }
        public string? Limite {get; set; }
        public string? TipoDeBloqueio {get; set; }
        public bool? ContaPadraoCNAB {get; set; }
        public bool? GeracaoDeBoleto {get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}