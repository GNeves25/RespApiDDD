using RespApiDDD.Domain.Core.Interfaces.Repositorys;
using RespApiDDD.Domain.Core.Interfaces.Services;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repository;

        public ServiceProduto(IRepositoryProduto repository) : base(repository)
        {
            _repository = repository;
        }
    }
}