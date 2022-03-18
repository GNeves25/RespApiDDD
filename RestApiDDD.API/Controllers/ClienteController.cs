using Microsoft.AspNetCore.Mvc;
using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;

namespace RestApiDDD.API.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClienteController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] DtoCliente dtoCliente)
        {
            try
            {
                if (dtoCliente == null)
                    return NotFound();

                _applicationServiceCliente.Add(dtoCliente);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] DtoCliente dtoCliente)
        {
            try
            {
                if (dtoCliente == null)
                    return NotFound();

                _applicationServiceCliente.Update(dtoCliente);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] DtoCliente dtoCliente)
        {
            try
            {
                if (dtoCliente == null)
                    return NotFound();

                _applicationServiceCliente.Remove(dtoCliente);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}