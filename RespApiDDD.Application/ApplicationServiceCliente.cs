using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;
using RespApiDDD.Domain.Core.Interfaces.Services;

namespace RespApiDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }
        public void Add(DtoCliente dtoCliente)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(dtoCliente);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<DtoCliente> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListDtoClientes(clientes);
        }

        public DtoCliente GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(DtoCliente dtoCliente)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(dtoCliente);
            _serviceCliente.Remove(cliente);
        }

        public void Update(DtoCliente dtoCliente)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(dtoCliente);
            _serviceCliente.Update(cliente);
        }
    }
}