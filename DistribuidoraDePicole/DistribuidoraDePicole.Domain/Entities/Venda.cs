using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Domain.Entities
{
    public class Venda : EntidadeBase
    {
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public string IdentificadorProduto { get; set; }
        public virtual Produto Produto { get; set; }
        public DateTime DataHoraDaVenda { get; set; }
        public int QuantidadeVendida { get; set; }
    }
}
