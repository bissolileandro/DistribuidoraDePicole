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
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DistribuidoraDePicoleContext context)
            :base(context)
        {

        }

        public async Task<Produto> GetById(int id)
        {
            return await db.Set<Produto>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Produto> GetByIdentificador(string idProduto)
        {
            return await db.Set<Produto>().FirstOrDefaultAsync(x => x.IdProduto == idProduto);
        }
    }
}
