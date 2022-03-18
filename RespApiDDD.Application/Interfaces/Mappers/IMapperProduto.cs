using RespApiDDD.Application.Dtos;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Application.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(DtoProduto dtoProduto);

        IEnumerable<DtoProduto> MapperListDtoProdutos(IEnumerable<Produto> produto);

        DtoProduto MapperEntityToDto(Produto produto);
    }
}