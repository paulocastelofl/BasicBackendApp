using ExcelDataReader;
using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GanEdenComex.Service.Services
{
    public class ItemService : IItemSevice
    {
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IBaseRepository<Fornecedor> _baseFornecedorRepository;
        private readonly IBaseRepository<Pais> _basePaisRepository;
        private readonly IBaseRepository<Item> _baseItemRepository;
        private readonly IBaseRepository<Ncm> _baseNcmRepository;


        public ItemService(
            IWebHostEnvironment env,
            IBaseRepository<Fornecedor> baseFornecedorRepository,
            IBaseRepository<Pais> basePaisRepository,
            IBaseRepository<Item> baseItemRepository,
            IBaseRepository<Ncm> baseNcmRepository,
            IHttpClientFactory httpClientFactory

            )
        {
            _appEnvironment = env;
            _baseFornecedorRepository = baseFornecedorRepository;
            _basePaisRepository = basePaisRepository;
            _baseItemRepository = baseItemRepository;
            _baseNcmRepository = baseNcmRepository;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<dynamic> SaveExcelFileItensAsync(IFormFile file, int IdEmpresa)
        {
            IExcelDataReader reader;

            if (file == null) throw new Exception("File is Not Received...");

            if (string.IsNullOrWhiteSpace(_appEnvironment.WebRootPath))
            {
                _appEnvironment.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
            }

            string dirPath = Path.Combine(_appEnvironment.WebRootPath, "ReceivedReports");
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string dataFileName = Path.GetFileName(file.FileName);

            string extension = Path.GetExtension(dataFileName);


            string[] allowedExtsnions = new string[] { ".xls", ".xlsx" };

            if (!allowedExtsnions.Contains(extension))
                throw new Exception("Sorry! This file is not allowed, make sure that file having extension as either.xls or.xlsx is uploaded.",
                new HttpResponseException(HttpStatusCode.BadRequest));

            string saveToPath = Path.Combine(dirPath, dataFileName);

            using (FileStream stream = new FileStream(saveToPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = new FileStream(saveToPath, FileMode.Open))
            {
                if (extension == ".xls")
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                else
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                DataSet ds = new DataSet();
                ds = reader.AsDataSet();
                reader.Close();

                if (ds != null && ds.Tables.Count > 0)
                {
                    DataTable serviceDetails = ds.Tables[0];

                    for (int i = 1; i < serviceDetails.Rows.Count; i++)
                    {
                        int codigoFornecedor = 0;

                        //Código Fabricante
                        if (serviceDetails.Rows[i][8].ToString() == "")
                        {
                            var fornecedor = _baseFornecedorRepository.Select()
                                .Where(x => x.NomeFantasia!.ToUpper()!.Equals(serviceDetails.Rows[i][9].ToString()!.ToUpper()) && x.IdEmpresa == IdEmpresa)
                                .ToList()
                                .FirstOrDefault();

                            if (fornecedor != null) codigoFornecedor = fornecedor.Id;
                            else codigoFornecedor = saveFornecedor(serviceDetails, i, IdEmpresa); //Cadastrar Fornecedor/Fabricante
                        }
                        else
                        {
                      
                            if(int.TryParse(serviceDetails.Rows[i][8].ToString(), out _))// Verifica se é um numero na coluna Fabricante
                            {
                                var fornecedor = _baseFornecedorRepository.Select(int.Parse(serviceDetails.Rows[i][8].ToString()!));

                                if (fornecedor != null) codigoFornecedor = fornecedor.Id;
                                else throw new Exception("Desculpe! Não foi possivel localizar o codigo do fornecedor na linha: " + i.ToString() + ".",
                                         new HttpResponseException(HttpStatusCode.BadRequest));
                            }   
                            else throw new Exception("Desculpe! Não foi possivel identificar o codigo do fornecedor na linha: "+i.ToString()+".",
                                new HttpResponseException(HttpStatusCode.BadRequest));
                        }

                        if (await isExistNcmAsync(serviceDetails.Rows[i][4].ToString()!, i))
                        {
                            var item = new Item
                            {
                                partNumber = serviceDetails.Rows[i][0].ToString(),
                                codigoInterno = serviceDetails.Rows[i][1].ToString(),
                                descricao = serviceDetails.Rows[i][2].ToString(),
                                descricaoItemNfe = serviceDetails.Rows[i][3].ToString(),
                                ncm = serviceDetails.Rows[i][4].ToString(),
                                unidadeOrganizacional = serviceDetails.Rows[i][7].ToString(),
                                IdFornecedor = codigoFornecedor,

                                aliquotaIi = float.Parse(serviceDetails.Rows[i][23].ToString()!),
                                aliquotaIpi = float.Parse(serviceDetails.Rows[i][24].ToString()!),
                                aliquotaPis = float.Parse(serviceDetails.Rows[i][25].ToString()!),
                                aliquotaCofins = float.Parse(serviceDetails.Rows[i][26].ToString()!),
                                IdEmpresa = IdEmpresa
                            };

                            _baseItemRepository.Insert(item);
                        }

                       
                    }

                }
            }
            return new { success = true, msg = "successfully" };
        }

        private int saveFornecedor(
            DataTable serviceDetails, 
            int i,
            int IdEmpresa
            )
        {
            var pais = _basePaisRepository.Select().Where(x => x.Nome!.ToUpper()!.Equals(serviceDetails.Rows[i][17].ToString()!.ToUpper())).ToList().FirstOrDefault();

            if (pais == null) throw new Exception("Desculpe! Não foi possivel localizar o país do fornecedor na linha: " + i.ToString() + ".",
                     new HttpResponseException(HttpStatusCode.BadRequest));

            var new_fornecedor = new Fornecedor
            {
                RazaoSocial = serviceDetails.Rows[i][9].ToString(),
                NomeFantasia = serviceDetails.Rows[i][9].ToString(),
                Logradouro = serviceDetails.Rows[i][10].ToString(),
                Numero = serviceDetails.Rows[i][11].ToString(),
                Bairro = serviceDetails.Rows[i][12].ToString(),
                Complemento = serviceDetails.Rows[i][13].ToString(),
                CEP = serviceDetails.Rows[i][14].ToString(),
                Cidade = serviceDetails.Rows[i][15].ToString(),
                Estado = serviceDetails.Rows[i][16].ToString(),
                IdPais = pais.Id,
                IdEmpresa = IdEmpresa

            };

            _baseFornecedorRepository.Insert(new_fornecedor);

            return new_fornecedor.Id;
        }

        private async Task<bool> isExistNcmAsync(string ncm, int i)
        {
            var ncm_result = _baseNcmRepository.Select().Where(x => x.Codigo == ncm).ToList().FirstOrDefault();

            if (ncm_result != null) {
                return true;
            } else
            {
                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://lb-api.brazilsouth.cloudapp.azure.com/ncm/"+ncm)
                {
                    Headers =
                    {
                        { "X-AuthToken", "NjIzOTgzMWEtNWIxMy00NWZkLWEwYTgtZjQ1ODA5NjM3ZThhOjoxNjc4NDc3NDcwODg1" },
                    }
                };

                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.SendAsync(httpRequestMessage);

                if (response.IsSuccessStatusCode)
                {

                    var value = await response.Content
                                        .ReadAsAsync<dynamic>();

                    if(value == null) throw new Exception("Desculpe! Não foi possivel localizar o ncm: " + i.ToString() + ".",
                     new HttpResponseException(HttpStatusCode.BadRequest));

                    var new_ncm = new Ncm
                    {
                        Id = value.id,
                        DtModificacao= value.dtModificacao,
                        VlIi = value.vlIi,
                        VlIiMercosul = value.vlIiMercosul,
                        VlIpi = value.vlIpi,
                        VlPis = value.vlPis,
                        VlCofins = value.vlCofins,
                        DtAtualizacao= value.dtAtualizacao,
                        Nome = value.nome,
                        Codigo= value.codigo

                    };

                    _baseNcmRepository.Insert(new_ncm);

                    if (new_ncm.Codigo == ncm) return true;
                }
            }

           throw new Exception("Desculpe! Não foi possivel localizar o ncm: " + i.ToString() + ".",
                     new HttpResponseException(HttpStatusCode.BadRequest)); ;
            
        }
    }
}
