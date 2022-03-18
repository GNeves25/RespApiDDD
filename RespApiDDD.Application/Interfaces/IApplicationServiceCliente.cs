using RespApiDDD.Application.Dtos;

namespace RespApiDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(DtoCliente dtoCliente);

        void Update(DtoCliente dtoCliente);

        void Remove(DtoCliente dtoCliente);

        IEnumerable<DtoCliente> GetAll();

        DtoCliente GetById(int id);
    }
}