using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class Empresa: BaseEntity
    {
        public string? CNPJ { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Logradouro { get; set;}
        public string? Numero { get; set; }
        public string? Complemento {get; set; }
        public string? Bairro {get; set; }
        public string? CEP {get; set; }
        public string? Cidade {get; set; }
        public string? Estado {get; set; }
        public string? InscricaoMunicipal {get; set;}
        public string? InscricaoSuframa {get; set; }
        [ForeignKey("Pais")]
        public int? IdPais { get; set; }
        public virtual Pais? Pais { get; set; }
    }
}