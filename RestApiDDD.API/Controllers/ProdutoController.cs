using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;

namespace RestApiDDD.API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] DtoProduto dtoProduto)
        {
            try
            {
                if (dtoProduto == null)
                    return NotFound();

                _applicationServiceProduto.Add(dtoProduto);
                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] DtoProduto dtoProduto)
        {
            try
            {
                if (dtoProduto == null)
                    return NotFound();

                _applicationServiceProduto.Update(dtoProduto);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] DtoProduto dtoProduto)
        {
            try
            {
                if (dtoProduto == null)
                    return NotFound();

                _applicationServiceProduto.Remove(dtoProduto);
                return Ok("Produto Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}