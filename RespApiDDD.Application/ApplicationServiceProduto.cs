using RespApiDDD.Application.Dtos;
using RespApiDDD.Application.Interfaces;
using RespApiDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RespApiDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }
        public void Add(DtoProduto dtoProduto)
        {
            var Produto = _mapperProduto.MapperDtoToEntity(dtoProduto);
            _serviceProduto.Add(Produto);
        }

        public IEnumerable<DtoProduto> GetAll()
        {
            var Produtos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListDtoProdutos(Produtos);
        }

        public DtoProduto GetById(int id)
        {
            var Produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(Produto);
        }

        public void Remove(DtoProduto dtoProduto)
        {
            var Produto = _mapperProduto.MapperDtoToEntity(dtoProduto);
            _serviceProduto.Remove(Produto);
        }

        public void Update(DtoProduto dtoProduto)
        {
            var Produto = _mapperProduto.MapperDtoToEntity(dtoProduto);
            _serviceProduto.Update(Produto);
        }
    }
}