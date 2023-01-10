using DistribuidoraDePicole.Domain.Entities;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;

namespace DistribuidoraDePicole.Application.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public string IdProduto { get; set; }
        public DateTime DataHoraDaVenda { get; set; }
        public int QuantidadeVendida { get; set; }

        public static IEnumerable<VendaModel> EntityToModel(IEnumerable<Venda> entities)
        {
            List<VendaModel> models = new List<VendaModel>();
            foreach (var item in entities)
            {
                models.Add(EntityToModel(item));
            }

            return models;
        }

        public static IEnumerable<Venda> ModelToEntity(IEnumerable<VendaModel> models)
        {
            List<Venda> entities = new List<Venda>();
            foreach (var item in models)
            {
                entities.Add(ModelToEntity(item));
            }
            return entities;
        }

        public static VendaModel EntityToModel(Venda entity)
        {
            return new VendaModel()
            {
                Id = entity.Id,
                IdVenda = entity.IdVenda,
                IdProduto = entity.Produto.IdProduto,
                DataHoraDaVenda = entity.DataHoraDaVenda,
                QuantidadeVendida = entity.QuantidadeVendida                
            };
        }

        public static Venda ModelToEntity(VendaModel model)
        {
            return new Venda()
            {
                Id = model.Id,
                IdVenda= model.IdVenda,
                IdentificadorProduto = model.IdProduto,
                DataHoraDaVenda = model.DataHoraDaVenda,
                QuantidadeVendida = model.QuantidadeVendida
            };
        }



    }
}
