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
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public async Task<Produto> GetById(int id)
        {
            return await produtoRepository.GetById(id);
        }

        public async Task<Produto> GetByIdentificador(string idProduto)
        {
            return await produtoRepository.GetByIdentificador(idProduto);
        }
    }
}
