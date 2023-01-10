using DistribuidoraDePicole.Application.Applications;
using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Domain.Interfaces.Services;
using DistribuidoraDePicole.Service.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DistribuidoraDePicole.Test.Applicatoin
{
    public class VendasApplicationTest
    {
        private VendaApplication vendaApplication;
        public VendasApplicationTest()
        {
            vendaApplication = new VendaApplication(new Mock<IVendaService>().Object, new Mock<IProdutoService>().Object);
        }

        [Fact]
        public async void AddVendas_Sucess()
        {
            List<Venda> vendas = VendasFake();
            var vendasRetorno = await vendaApplication.AddVendasAsync(vendas);
            Assert.NotNull(vendasRetorno);
        }

        private Venda VendaFake()
        {
            return new Venda()
            {
                Id = 0,
                DataHoraDaVenda = DateTime.Now,
                IdentificadorProduto = "AB123",
                IdProduto = 1,
                IdVenda = 1,
                Produto = null,
                QuantidadeVendida = 1
            };
        }

        private List<Venda> VendasFake()
        {
            var listaVendas = new List<Venda>();
            var venda = VendaFake();
            listaVendas.Add(venda);
            venda = VendaFake();
            listaVendas.Add(venda);

            return listaVendas;

        }
    }
}
