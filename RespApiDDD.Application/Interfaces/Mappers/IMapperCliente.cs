using RespApiDDD.Application.Dtos;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Application.Interfaces
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(DtoCliente dtoCliente);

        IEnumerable<DtoCliente> MapperListDtoClientes(IEnumerable<Cliente> clientes);

        DtoCliente MapperEntityToDto(Cliente classeCliente);
    }
}