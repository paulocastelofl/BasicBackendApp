using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class ProcessoImportacao: BaseEntity
    {
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        public int? Despachante {get; set; } //chave estrangeira p/ Empresa
        public int? DespachantePonta { get; set; } //chave estrangeira p/ Empresa
        public string? Codigo { get; set; }
        public DateTime? DtCriacao { get; set; }
        public DateTime? DtModificacao { get; set; }
        public DateTime? DtUltimoEvento { get; set; }
        public string? UltimoEvento { get; set; }
        public string? TipoDeDeclaracao { get; set; }
        [ForeignKey("Pais")]
        public int? IdPais { get; set; }
        public virtual Pais? Pais { get; set; }
        public int? Modal { get; set; } //chave estrangeira p/ Modal
        public int? UrfdeChegada { get; set; } //chave estrangeira p/ Urf
        public int? UrfdeDespacho { get; set; } //chave estrangeira p/ Urf
    }
}
