using DistribuidoraDePicole.Application.Models;
using DistribuidoraDePicole.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoApplication produtoApplication;
        public ProdutosController(IProdutoApplication produtoApplication)
        {
            this.produtoApplication = produtoApplication;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var listaProdutos = ProdutoModel.EntityToModel(await produtoApplication.GetAllAsync());
                return Ok(listaProdutos);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var produto = ProdutoModel.EntityToModel(await produtoApplication.GetById(id));
                return Ok(produto);
            }
            catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpPost]
        [Route("InserirProduto")]
        public async Task<IActionResult> InserirProduto([FromBody] ProdutoModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = await produtoApplication.AddAsync(ProdutoModel.ModelToEntity(model));
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
