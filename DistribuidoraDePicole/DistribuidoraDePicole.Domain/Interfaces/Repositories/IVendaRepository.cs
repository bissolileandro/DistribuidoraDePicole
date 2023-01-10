using DistribuidoraDePicole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Interfaces.Repositories
{
    public interface IVendaRepository : IRepositoryBase<Venda>
    {
        Task<IEnumerable<Venda>> GetAllVendas();
    }
}
