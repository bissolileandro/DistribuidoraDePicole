using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Entities
{
    public class Produto : EntidadeBase
    {
        public string IdProduto { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeRetiradaVenda { get; set; }
        public int ValidadeForadoFreezer { get; set; }
    }
}
