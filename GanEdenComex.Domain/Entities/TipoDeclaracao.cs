using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class TipoDeclaracao: BaseEntityAux
    {
        public bool? saidaEntreposto { get; set; }
        public bool? entradaEntreposto { get; set; }
        public bool? admissaoTemporaria { get; set; }
        public bool? recolheAntidumpingRegistro { get; set; }
        public bool? entradaEizof { get; set; }
    }
}
