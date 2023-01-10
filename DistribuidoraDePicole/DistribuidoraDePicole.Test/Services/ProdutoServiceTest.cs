
using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Service.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DistribuidoraDePicole.Test.Services
{
    public class ProdutoServiceTest
    {
        private ProdutoService produtoService;
        public ProdutoServiceTest()
        {
            this.produtoService = new ProdutoService(new Mock<IProdutoRepository>().Object);
        }

        [Fact]
        public async void GetAll_Sucess()
        {
            var produto = ProdutoFake();
            await produtoService.AddAsync(produto);
            var produtoRetorno = await produtoService.GetAllAsync();
            Assert.NotNull(produtoRetorno);
        }

        private Produto ProdutoFake()
        {
            return new Produto()
            {
                Id = 0,
                Descricao = "Teste",
                IdProduto = "123456",
                QuantidadeEstoque = 100,
                QuantidadeRetiradaVenda = 200,
                ValidadeForadoFreezer = 4
            };
        }

    }
}
