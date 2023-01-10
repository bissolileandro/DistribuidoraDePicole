using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Service.Services
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IVendaRepository vendaRepository;
        public VendaService(IVendaRepository vendaRepository)
            : base(vendaRepository) 
        {
            this.vendaRepository = vendaRepository;
        }

        public async Task<IEnumerable<Venda>> GetAllVendas()
        {
            return await vendaRepository.GetAllVendas();
        }
    }
}
