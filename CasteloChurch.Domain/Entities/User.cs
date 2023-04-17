using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CasteloChurch.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? Cpf { get; set; }

        public string? Telefone { get; set; }
      
    
    }
}
