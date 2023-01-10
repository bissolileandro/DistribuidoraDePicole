using DistribuidoraDePicole.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Application.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string IdProduto { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeRetiradaVenda { get; set; }
        public int ValidadeForadoFreezer { get; set; }

       public static IEnumerable<ProdutoModel> EntityToModel(IEnumerable<Produto> entities)
        {
            List<ProdutoModel> models = new List<ProdutoModel>();
            foreach (var item in entities)
            {
                models.Add(EntityToModel(item));
            }

            return models;
        }
        public static ProdutoModel EntityToModel(Produto entity)
        {
            return new ProdutoModel() 
            { 
                Id = entity.Id,
                IdProduto = entity.IdProduto,
                Descricao = entity.Descricao,
                QuantidadeEstoque = entity.QuantidadeEstoque,
                QuantidadeRetiradaVenda = entity.QuantidadeRetiradaVenda,
                ValidadeForadoFreezer = entity.ValidadeForadoFreezer
            };
        }
        public static IEnumerable<Produto> ModelToEntity(IEnumerable<ProdutoModel> models)
        {
            List<Produto> entities = new List<Produto>();
            foreach (var item in models)
            {
                entities.Add(ModelToEntity(item));
            }
            return entities;
        }
        public static Produto ModelToEntity(ProdutoModel model)
        {
            return new Produto()
            {
                Id = model.Id,
                IdProduto = model.IdProduto,
                Descricao = model.Descricao,
                QuantidadeEstoque = model.QuantidadeEstoque,
                QuantidadeRetiradaVenda = model.QuantidadeRetiradaVenda,
                ValidadeForadoFreezer = model.ValidadeForadoFreezer
            };
        }
    }
}
