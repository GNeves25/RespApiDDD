using Autofac;
using RespApiDDD.Application;
using RespApiDDD.Application.Interfaces;
using RespApiDDD.Application.Mappers;
using RespApiDDD.Domain.Core.Interfaces.Repositorys;
using RespApiDDD.Domain.Core.Interfaces.Services;
using RespApiDDD.Domain.Services;
using RespApiDDD.Infrastructure.Data.Repositorys;

namespace RespApiDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}