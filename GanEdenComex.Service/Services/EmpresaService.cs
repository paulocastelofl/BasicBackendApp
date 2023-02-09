using GanEdenComex.Domain.Entities;
using GanEdenComex.Domain.Interfaces;
using GanEdenComex.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GanEdenComex.Service.Services
{
    public class EmpresaService: IEmpresaService
    {
        private readonly IBaseRepository<Empresa> _baseRepository;


        public EmpresaService(IBaseRepository<Empresa> baseRepository)
        {
            _baseRepository = baseRepository;
           
        }

        public IList<Empresa> GetByEmpresa(int id)
        {
            return _baseRepository.Select().Where(x => x.IdEmpresa == id).ToList();
        }

        public Empresa UpdateStatus(int id, bool status)
        {
            var user = _baseRepository.Select(id);
            if (user == null) throw new Exception("Invalid User", new HttpResponseException(HttpStatusCode.NotFound));

            user.status = status;
            _baseRepository.Update(user);

            return user;

        }
    }
}
