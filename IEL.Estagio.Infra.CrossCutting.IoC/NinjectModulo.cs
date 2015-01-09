using Ninject.Modules;
using IEL.Estagio.Application.Interfaces;
using IEL.Estagio.Domain.Interfaces.Repository;
//using IEL.Estagio.Domain.Interfaces.Repository.ADO;
//using IEL.Estagio.Domain.Interfaces.Repository.ReadOnly;
using IEL.Estagio.Domain.Interfaces.Services;
using IEL.Estagio.Domain.Services;
using IEL.Estagio.Infra.Data.Context;
using IEL.Estagio.Infra.Data.Interfaces;
using IEL.Estagio.Infra.Data.Repositories;
//using IEL.Estagio.Infra.Data.Repositories.ADO;
//using IEL.Estagio.Infra.Data.Repositories.ReadOnly;
using IEL.Estagio.Infra.Data.UoW;
using IEL.Estagio.Application.Services;

namespace IEL.Estagio.Infra.CrossCutting.IoC
{
    public class NinjectModulo : NinjectModule
    {
        public override void Load()
        {
            // app
            Bind<IEstudanteAppService>().To<EstudanteAppService>();
            Bind<IVagaAppService>().To<VagaAppService>();
            Bind<IEmpresaAppService>().To<EmpresaAppService>();

            // service
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IEstudanteService>().To<EstudanteService>();
            Bind<IVagaService>().To<VagaService>();
            Bind<IEmpresaService>().To<EmpresaService>();

            // data repos
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<,>));
            Bind<IEstudanteRepository>().To<EstudanteRepository>();
            Bind<IVagaRepository>().To<VagaRepository>();
            Bind<IEmpresaRepository>().To<EmpresaRepository>();

            // data repos read only
            //Bind<IClienteReadOnlyRepository>().To<ClienteReadOnlyRepository>();
            //Bind<IFornecedorReadOnlyRepository>().To<FornecedorReadOnlyRepository>();
            //Bind<IVendaReadOnlyRepository>().To<VendaReadOnlyRepository>();
            //Bind<IProdutoReadOnlyRepository>().To<ProdutoReadOnlyRepository>();

            // ado repos only
            //Bind<IClienteADORepository>().To<ClienteADORepository>();

            // data configs
            Bind(typeof(IContextManager<>)).To(typeof(ContextManager<>));
            Bind<IDbContext>().To<IELEstagioContext>();
            Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>));

        }
    }
}
