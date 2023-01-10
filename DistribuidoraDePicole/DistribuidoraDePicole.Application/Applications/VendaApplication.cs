using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using DistribuidoraDePicole.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Application.Applications
{
    public class VendaApplication : ApplicationBase<Venda>, IVendaApplication
    {
        private readonly IVendaService vendaService;
        private readonly IProdutoService produtoService;
        public VendaApplication(IVendaService vendaService, IProdutoService produtoService)
            : base(vendaService) 
        {
            this.vendaService = vendaService;
            this.produtoService = produtoService;
        }

        public async Task<Venda> AddVendaAsync(Venda venda)
        {
            var retorno = new Venda();
            if (venda != null)
            {
                if (venda.IdProduto == 0)
                {
                    var produto = await produtoService.GetByIdentificador(venda.IdentificadorProduto);
                    venda.IdProduto = produto.Id;
                }
                 retorno = await vendaService.AddAsync(venda);
            }
            return retorno;
        }

        public async Task<IEnumerable<Venda>> AddVendasAsync(IEnumerable<Venda> vendas)
        {
            var retorno = new List<Venda>();
            if (vendas.Count() > 0)
            {
                foreach (var item in vendas)
                {
                    var itemAdicionado = await AddVendaAsync(item);
                    retorno.Add(itemAdicionado);
                }
            }
            return retorno.ToList();
        }

        public async Task<IEnumerable<Venda>> GetAllVendas()
        {
            return await vendaService.GetAllVendas();
        }
    }
}
