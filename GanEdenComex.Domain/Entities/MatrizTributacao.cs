using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class MatrizTributacao: BaseEntity
    {
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
        [ForeignKey("InscricaoEstadual")]
        public int? IdInscricaoEstadual { get; set; }
        public virtual InscricaoEstadual? InscricaoEstadual { get; set; }
        [ForeignKey("ProdutoSuframa")]
        public int? IdProdutoSuframa { get; set; }
        public virtual ProdutoSuframa? ProdutoSuframa { get; set; }
        [ForeignKey("Ncm")]
        public int? IdNcm { get; set; }
        public virtual Ncm? Ncm { get; set; }
        [ForeignKey("Destinacao")]
        public int? IdDestinacao { get; set; }
        public virtual Destinacao? Destinacao { get; set; }
        [ForeignKey("Utilizacao")]
        public int? IdUtilizacao { get; set; }
        public virtual Utilizacao? Utilizacao { get; set; }
        [ForeignKey("Tributacao")]
        public int? IdTributacao { get; set; }
        public virtual Tributacao? Tributacao { get; set; }
        public double? Cra { get; set; }
        [ForeignKey("TipoDoc")]
        public int? IdTipoDoc { get; set; }
        public virtual TipoDoc? TipoDoc { get; set; }
        public string? Decreto { get; set; }
        public string? NumeroDocumento { get; set; }
        public DateTime? InicioVigencia { get; set; }
        public DateTime? FimVigencia { get; set; }
    }
}