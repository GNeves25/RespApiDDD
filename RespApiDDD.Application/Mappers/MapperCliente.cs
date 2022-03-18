using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public IEnumerable<DtoCliente> MapperListDtoClientes(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(cliente => new DtoCliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            }
            );

            return dto;
        }

        public Cliente MapperDtoToEntity(DtoCliente dtoCliente)
        {
            var cliente = new Cliente()
            {
                Id = dtoCliente.Id,
                Nome = dtoCliente.Nome,
                Sobrenome = dtoCliente.Sobrenome,
                Email = dtoCliente.Email
            };

            return cliente;
        }

        public DtoCliente MapperEntityToDto(Cliente cliente)
        {
            var dtoCliente = new DtoCliente()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return dtoCliente;
        }
    }
}