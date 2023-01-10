using DistribuidoraDePicole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Interfaces.Services
{
    public interface IVendaService : IServiceBase<Venda>
    {
        Task<IEnumerable<Venda>> GetAllVendas();
    }
}
