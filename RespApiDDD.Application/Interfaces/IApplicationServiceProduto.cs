using RespApiDDD.Application.Dtos;

namespace RespApiDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(DtoProduto dtoCliente);

        void Update(DtoProduto dtoCliente);

        void Remove(DtoProduto dtoCliente);

        IEnumerable<DtoProduto> GetAll();

        DtoProduto GetById(int id);
    }
}