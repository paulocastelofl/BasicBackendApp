﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.DTO
{
    public class ProdutoSuframaDTO
    {
        public string? nome { get; set; }
        public string? codigo { get; set; }
        public DateTime? dtModificacao { get; set; }
         public bool ativo { get; set; }
    }
}
