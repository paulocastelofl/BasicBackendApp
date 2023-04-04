using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public  class DocumentoImportacao: BaseEntity
    {
        public string? Documento { get; set; }
        public string? CaminhoDocumento { get; set; }
        public string? Tipo { get; set; }
        public string? Versao { get; set; }
        public string? Numero { get; set; }
        public string? Recebimento { get; set; }

        public DateTime? DtCriacao { get; set; } = DateTime.Now;

        [ForeignKey("ProcessoImportacao")]
        public int? IdProcesso { get; set;}
        public virtual ProcessoImportacao? ProcessoImportacao { get; set; }
    }
}
