using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;
using RespApiDDD.Domain.Entitys;

namespace RespApiDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public IEnumerable<DtoProduto> MapperListDtoProdutos(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(produto => new DtoProduto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            }
            );

            return dto;
        }

        public Produto MapperDtoToEntity(DtoProduto dtoProduto)
        {
            var Produto = new Produto()
            {
                Id = dtoProduto.Id,
                Nome = dtoProduto.Nome,
                Valor = dtoProduto.Valor
            };

            return Produto;
        }

        public DtoProduto MapperEntityToDto(Produto produto)
        {
            var dtoProduto = new DtoProduto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return dtoProduto;
        }
    }
}