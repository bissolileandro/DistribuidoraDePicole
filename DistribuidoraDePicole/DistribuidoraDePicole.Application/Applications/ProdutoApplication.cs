using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using DistribuidoraDePicole.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;


namespace DistribuidoraDePicole.Application.Applications
{
    public class ProdutoApplication : ApplicationBase<Produto>, IProdutoApplication
    {
        private readonly IProdutoService produtoService;
        public ProdutoApplication(IProdutoService produtoService)
            :base(produtoService)
        {
            this.produtoService = produtoService;
        }

        public async Task<Produto> GetById(int id)
        {
            try
            {
                return await produtoService.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }            
        }

        public async Task<Produto> GetByIdentificador(string idProduto)
        {
            return await produtoService.GetByIdentificador(idProduto);
        }
    }
}
