using GanEdenComex.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Interfaces
{
    public interface IItemSevice
    {
        Task<string> SaveExcelFileItensAsync(IFormFile file, int IdEmpresa);
    }
}
