using DistribuidoraDePicole.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Interfaces.Applications
{
    public interface IProdutoApplication : IApplicationBase<Produto>
    {
        Task<Produto> GetById(int id);
        Task<Produto> GetByIdentificador(string idProduto);
    }
}
