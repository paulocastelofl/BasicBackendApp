using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;

namespace GanEdenComex.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class BaseTablesAuxController : Controller
    {
        
        private IBaseService<CoberturaCambial> _baseCoberturaCambial;
        private IBaseService<MotivoSemCobertura_cambial> _baseMotivoSemCobertura;
        private IBaseService<ZFMDestinacao> _baseZFMDestinacao;
        private IBaseService<ZFMUtilizacao> _baseZFMUtilizacao;
        private IBaseService<ZFMAplicacaoMaterial> _baseZFMAplicacaoMaterial;
        private IBaseService<RegimeTributavel> _baseRegimeTributavel;
        private IBaseService<FundamentoLegal> _baseFundamentoLegal;
        private IBaseService<TipoAcordoTarifario> _baseTipoAcordoTarifario;
        private IBaseService<AcordoAladi> _baseAcordoAladi;
        private IBaseService<Unidade> _baseUnidade;
        private IBaseService<Naladi> _baseNaladi;
        private IBaseService<Ncm> _baseNcm;
        private IBaseService<TipoDeclaracao> _baseTipoDecalaracao;
        private IBaseService<Urf> _baseUrf;
        private IBaseService<Modal> _baseModal;

        public BaseTablesAuxController(

             IBaseService<CoberturaCambial> baseCoberturaCambial,
             IBaseService<MotivoSemCobertura_cambial> baseMotivoSemCobertura,
             IBaseService<ZFMDestinacao> baseZFMDestinacao,
             IBaseService<ZFMUtilizacao> baseZFMUtilizacao,
             IBaseService<ZFMAplicacaoMaterial> baseZFMAplicacaoMaterial,
             IBaseService<RegimeTributavel> baseRegimeTributavel,
             IBaseService<FundamentoLegal> baseFundamentoLegal,
             IBaseService<TipoAcordoTarifario> baseTipoAcordoTarifario,
             IBaseService<AcordoAladi> baseAcordoAladi,
             IBaseService<Unidade> baseUnidade,
             IBaseService<Naladi> baseNaladi,
             IBaseService<Ncm> baseNcm,
             IBaseService<TipoDeclaracao> baseTipoDecalaracao,
             IBaseService<Urf> baseUrf,
             IBaseService<Modal> baseModal
        )
        {
              _baseCoberturaCambial = baseCoberturaCambial;
              _baseMotivoSemCobertura = baseMotivoSemCobertura;
              _baseZFMDestinacao = baseZFMDestinacao;
              _baseZFMUtilizacao = baseZFMUtilizacao;
              _baseZFMAplicacaoMaterial = baseZFMAplicacaoMaterial;
              _baseRegimeTributavel = baseRegimeTributavel;
              _baseFundamentoLegal = baseFundamentoLegal;
              _baseTipoAcordoTarifario = baseTipoAcordoTarifario;
              _baseAcordoAladi = baseAcordoAladi;
              _baseUnidade = baseUnidade;
              _baseNaladi = baseNaladi;
              _baseNcm = baseNcm;
              _baseTipoDecalaracao = baseTipoDecalaracao;
               _baseUrf = baseUrf;
              _baseModal = baseModal;
        }

        [HttpPost("CoberturaCambial")]
        public IActionResult Create([FromBody] CoberturaCambial coberturaCambial)
        {
            if (coberturaCambial == null)
                return NotFound();

            try
            {
                return Ok(_baseCoberturaCambial.Add(coberturaCambial));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("CoberturaCambial")]
        public ActionResult<IList<CoberturaCambial>> Get()
        {
            try
            {
                return _baseCoberturaCambial.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("MotivoSemCobertura_cambial")]
        public IActionResult CreateMotivoSemCobertura_cambial([FromBody] MotivoSemCobertura_cambial motivoSemCobertura_cambial)
        {
            if (motivoSemCobertura_cambial == null)
                return NotFound();

            try
            {
                return Ok(_baseMotivoSemCobertura.Add(motivoSemCobertura_cambial));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("MotivoSemCobertura_cambial")]
        public ActionResult<IList<MotivoSemCobertura_cambial>> GetMotivoSemCobertura_cambial()
        {
            try
            {
                return _baseMotivoSemCobertura.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("ZFMDestinacao")]
        public IActionResult CreateZFMDestinacao([FromBody] ZFMDestinacao zfmDestinacao)
        {
            if (zfmDestinacao == null)
                return NotFound();

            try
            {
                return Ok(_baseZFMDestinacao.Add(zfmDestinacao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("ZFMDestinacao")]
        public ActionResult<IList<ZFMDestinacao>> GetZFMDestinacao()
        {
            try
            {
                return _baseZFMDestinacao.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("ZFMUtilizacao")]
        public IActionResult CreateZFMUtilizacao([FromBody] ZFMUtilizacao zfmUtilizacao)
        {
            if (zfmUtilizacao == null)
                return NotFound();

            try
            {
                return Ok(_baseZFMUtilizacao.Add(zfmUtilizacao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("ZFMUtilizacao")]
        public ActionResult<IList<ZFMUtilizacao>> GetZFMUtilizacao()
        {
            try
            {
                return _baseZFMUtilizacao.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("ZFMAplicacaoMaterial")]
        public IActionResult CreateZFMAplicacaoMaterial([FromBody] ZFMAplicacaoMaterial zfmAplicacaoMaterial)
        {
            if (zfmAplicacaoMaterial == null)
                return NotFound();

            try
            {
                return Ok(_baseZFMAplicacaoMaterial.Add(zfmAplicacaoMaterial));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("ZFMAplicacaoMaterial")]
        public ActionResult<IList<ZFMAplicacaoMaterial>> GetZFMAplicacaoMaterial()
        {
            try
            {
                return _baseZFMAplicacaoMaterial.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("RegimeTributavel")]
        public IActionResult CreateRegimeTributavel([FromBody] RegimeTributavel regimeTributavel)
        {
            if (regimeTributavel == null)
                return NotFound();

            try
            {
                return Ok(_baseRegimeTributavel.Add(regimeTributavel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("RegimeTributavel")]
        public ActionResult<IList<RegimeTributavel>> GetRegimeTributavel()
        {
            try
            {
                return _baseRegimeTributavel.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("FundamentoLegal")]
        public IActionResult CreateFundamentoLegal([FromBody] FundamentoLegal fundamentoLegal)
        {
            if (fundamentoLegal == null)
                return NotFound();

            try
            {
                return Ok(_baseFundamentoLegal.Add(fundamentoLegal));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("FundamentoLegal")]
        public ActionResult<IList<FundamentoLegal>> GetFundamentoLegal()
        {
            try
            {
                return _baseFundamentoLegal.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("TipoAcordoTarifario")]
        public IActionResult CreateTipoAcordoTarifario([FromBody] TipoAcordoTarifario tipoAcordoTarifario)
        {
            if (tipoAcordoTarifario == null)
                return NotFound();

            try
            {
                return Ok(_baseTipoAcordoTarifario.Add(tipoAcordoTarifario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("TipoAcordoTarifario")]
        public ActionResult<IList<TipoAcordoTarifario>> GetTipoAcordoTarifariol()
        {
            try
            {
                return _baseTipoAcordoTarifario.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("AcordoAladi")]
        public IActionResult CreateAcordoAladi([FromBody] AcordoAladi acordoAladi)
        {
            if (acordoAladi == null)
                return NotFound();

            try
            {
                return Ok(_baseAcordoAladi.Add(acordoAladi));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("AcordoAladi")]
        public ActionResult<IList<AcordoAladi>> GetAcordoAladi()
        {
            try
            {
                return _baseAcordoAladi.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("Unidade")]
        public IActionResult CreateUnidade([FromBody] Unidade unidade)
        {
            if (unidade == null)
                return NotFound();

            try
            {
                return Ok(_baseUnidade.Add(unidade));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("Unidade")]
        public ActionResult<IList<Unidade>> GetUnidade(string q)
        {
            try
            {
                return _baseUnidade.Get().Where(x => (x.codigo! + x.nome!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


        //*****************************************************************************************//

        [HttpPost("TipoDeclaracao")]
        public IActionResult CreateTipoDeclaracao([FromBody] TipoDeclaracao tipoDeclaracao)
        {
            if (tipoDeclaracao == null)
                return NotFound();

            try
            {
                return Ok(_baseTipoDecalaracao.Add(tipoDeclaracao));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("TipoDeclaracao")]
        public ActionResult<IList<TipoDeclaracao>> GetTipoDeclaracao(string q)
        {
            try
            {
                return _baseTipoDecalaracao.Get().Where(x => (x.codigo! + x.nome!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("Urf")]
        public IActionResult CreateUrf([FromBody] Urf urf)
        {
            if (urf == null)
                return NotFound();

            try
            {
                return Ok(_baseUrf.Add(urf));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("Urf")]
        public ActionResult<IList<Urf>> GetUrf(string q)
        {
            try
            {
                return _baseUrf.Get().Where(x => (x.codigo! + x.nome!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


        //*****************************************************************************************//

        [HttpPost("modal")]
        public IActionResult CreateModal([FromBody] Modal modal)
        {
            if (modal == null)
                return NotFound();

            try
            {
                return Ok(_baseModal.Add(modal));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("Modal")]
        public ActionResult<IList<Modal>> GetModal()
        {
            try
            {
                return _baseModal.Get().ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        //*****************************************************************************************//

        [HttpPost("Naladi")]
        public IActionResult CreateNaladi([FromBody] Naladi naladi)
        {
            if (naladi == null)
                return NotFound();

            try
            {
                return Ok(_baseNaladi.Add(naladi));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpGet("Naladi")]
        public ActionResult<IList<Naladi>> GetNaladi(string q)
        {
            try
            {
                return _baseNaladi.Get().Where(x => (x.codigo! + x.nome!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


        [HttpGet("Ncm")]
        public ActionResult<IList<Ncm>> GetNcm(string q)
        {
            try
            {
                return _baseNcm.Get().Where(x => (x.Codigo!).ToUpper().Contains(q.ToUpper())).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
