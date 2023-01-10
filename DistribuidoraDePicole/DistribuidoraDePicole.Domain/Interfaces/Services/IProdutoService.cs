﻿using DistribuidoraDePicole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        Task<Produto> GetById(int id);
        Task<Produto> GetByIdentificador(string idProduto);
    }
}
