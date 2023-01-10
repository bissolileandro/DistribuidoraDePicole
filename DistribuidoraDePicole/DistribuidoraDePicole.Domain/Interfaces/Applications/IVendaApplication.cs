using DistribuidoraDePicole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Interfaces.Applications
{
    public interface IVendaApplication : IApplicationBase<Venda>
    {
        Task<Venda> AddVendaAsync(Venda venda);
        Task<IEnumerable<Venda>> AddVendasAsync(IEnumerable<Venda> vendas);
        Task<IEnumerable<Venda>> GetAllVendas();
    }
}
