using RespApiDDD.Domain.Core.Interfaces.Repositorys;
using RespApiDDD.Domain.Core.Interfaces.Services;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repository;

        public ServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            _repository = repository;
        }
    }
}