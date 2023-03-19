using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.DTO
{
    public class EmpresaDTO
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
        public bool? Despachante { get; set; }
        public bool? Importador { get; set; }
        public bool? Exportador { get; set; }
        public string? InscricaoSuframa {get; set; }
        //Faltam as foreign keys
        public string? CNAE {get; set; }
        public string? NumeroDeCadastroNoMA {get; set; }
        public double? LimiteDeValorFOB {get; set; }
        public string? DespachantePadrao {get; set; }
        public int? PrazoDiasCEMercanteCritico {get; set; }
        public string? CentroDeCusto {get; set; }
        public bool? CadastroDeItens {get; set; }
        public bool? AtualizarItens {get; set; }
        public bool? CadastroDeFornecedoresFabricantes {get; set; }
        public bool? AtualizarFornecedoresFabricantes {get; set; }
        public bool? ControlarDemurrage {get; set; }
        public bool? ControlarCEMercantes {get; set; }
        public bool? ControlarCambio {get; set; }
        public bool? Segurado {get; set; }
        public int? NumeroSequencialFIEAM { get; set; }
    }
}
