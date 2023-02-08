using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class User: BaseEntity
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
        //[JsonIgnore]
        public string? Password { get; set; }

        public string? Cpf { get; set; }

        public string? Telefone { get; set; }
        [ForeignKey("Empresa")]
        public int? IdEmpresa { get; set; }
        public virtual Empresa? Empresa { get; set; }
    }
}
