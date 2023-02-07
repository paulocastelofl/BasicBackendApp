using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class RepresentanteLegal: BaseEntity
    {
        public string? CPF { get; set; }
        public string? CNPJ { get; set; }
        public string? MarinhaMercante { get; set; }
        public string? RegistroRepresentante { get; set; }
        public string? SenhaSISCOMEX { get; set;}
        public string? SenhaSUFRAMA { get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        [ForeignKey("CertificadoDigital")]
        public int? IdCertificadoDigital {get; set; }
        public virtual CertificadoDigital? CertificadoDigital {get; set; }
    }
}