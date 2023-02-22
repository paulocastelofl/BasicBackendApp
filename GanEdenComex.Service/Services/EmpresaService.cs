using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GanEdenComex.Service.Services
{
    public class EmpresaService: IEmpresaService
    {
        private readonly IBaseRepository<Empresa> _baseRepository;
        private readonly IBaseRepository<InscricaoEstadual> _baseRepositoryInscricaoEstadual;
        protected readonly PostgresContext _postgresctx;


        public EmpresaService(
            IBaseRepository<Empresa> baseRepository,
            IBaseRepository<InscricaoEstadual> baseRepositoryInscricaoEstadual,
            PostgresContext postgresctx
            )
        {
            _baseRepository = baseRepository;
            _baseRepositoryInscricaoEstadual = baseRepositoryInscricaoEstadual;
            _postgresctx = postgresctx;
        }

        public IList<Empresa> GetByEmpresa(int id)
        {
            return _baseRepository.Select().Where(x => x.IdEmpresa == id).ToList();
        }

        public Empresa Update(Empresa obj)
        {


            var empresa = _baseRepository.Select(obj.Id);

            if (empresa != null)
             {
                _postgresctx.Entry(empresa).CurrentValues.SetValues(obj);
                _postgresctx.Entry(empresa).State = EntityState.Modified;
                _postgresctx.SaveChanges();

                foreach (var inscricaoEstadual in empresa.InscricaoEstaduais!.ToList())
                 {

                     bool hasElements = obj.InscricaoEstaduais!.Any(c => c.Id == inscricaoEstadual.Id);

                     if (!hasElements) _baseRepositoryInscricaoEstadual.Delete(inscricaoEstadual.Id);

                 }

                 // Update and Insert children
                 foreach (var inscricaoEstadual in obj.InscricaoEstaduais!)
                 {
                   if(inscricaoEstadual.Id == 0)
                     {
                         _baseRepositoryInscricaoEstadual.Insert(inscricaoEstadual);
                     }
                 }
             }
             else
             {
                 throw new Exception("Invalid Data", new HttpResponseException(HttpStatusCode.NotFound));
             }

            return obj;
        }

        public Empresa UpdateStatus(int id, bool status)
        {
            var empresa = _baseRepository.Select(id);
            if (empresa == null) throw new Exception("Invalid Data", new HttpResponseException(HttpStatusCode.NotFound));

            empresa.status = status;
            _baseRepository.Update(empresa);

            return empresa;

        }
    }
}
