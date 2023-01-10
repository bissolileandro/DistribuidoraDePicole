using DistribuidoraDePicole.Application.Models;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendaApplication vendaApplication;
        public VendasController(IVendaApplication vendaApplication)
        {
            this.vendaApplication = vendaApplication;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll() 
        {
            try
            {
                var listaVendas = await vendaApplication.GetAllVendas();
                var listaVendasModel = VendaModel.EntityToModel(listaVendas);
                return Ok(listaVendasModel);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro ao Consultar lista de Vendas {e.Message}");
            }
        }

        [HttpPost]
        [Route("InserirVenda")]
        public async Task<IActionResult> InserirVenda([FromBody] VendaModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = await vendaApplication.AddVendaAsync(VendaModel.ModelToEntity(model));
                    return Ok(retorno);
                }
                return BadRequest($"Erro: modelo informado não é valido para persistir os dados!");
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpPost]
        [Route("InserirVendas")]
        public async Task<IActionResult> InserirVendas([FromBody] IEnumerable<VendaModel> models)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = await vendaApplication.AddVendasAsync(VendaModel.ModelToEntity(models));
                    return Ok(retorno);
                }
                return BadRequest($"Erro: modelo informado não é valido para persistir os dados!");
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }
    }
}
