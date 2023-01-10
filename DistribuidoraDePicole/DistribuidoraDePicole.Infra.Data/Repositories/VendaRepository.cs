using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Infra.Data.Repositories
{
    public class VendaRepository : RepositoryBase<Venda>, IVendaRepository
    {
        public VendaRepository(DistribuidoraDePicoleContext context)
            : base(context)
        {

        }

        public async Task<IEnumerable<Venda>> GetAllVendas()
        {
            var listaVendas = await db.Set<Venda>().Include(p => p.Produto).ToListAsync();
            return listaVendas.ToList();

        }
    }
}
