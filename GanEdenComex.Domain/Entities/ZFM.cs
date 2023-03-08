using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class ZFM: BaseEntity
    {
       public int? RepresentanteLegal { get; set; }
       public string? NumeroSequencialPLI { get; set; }
       public string? SenhaSuframa { get; set; }
       public bool? Industria { get; set; }
       public bool? DTE { get; set; }
       public bool? ResponsavelSefaz { get; set; }
       public bool? OptanteLei2826 { get; set; }
       public bool? ArmazenaArquivoRetornoPLI { get; set; }
       [ForeignKey("Empresa")]
       public int? IdEmpresa { get; set; }
       public virtual Empresa? Empresa { get; set; }
    }
}