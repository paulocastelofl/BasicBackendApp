using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class TipoDocumentos: BaseEntity
    {
        public string? NomeTipoDocumento { get; set; }
        public string? TipoSiscomexDocumento { get; set; }
        [ForeignKey("Documentos")]
        public int? IdDocumentos { get; set; }
        public virtual Documentos? Documentos { get; set; }
    }
}
