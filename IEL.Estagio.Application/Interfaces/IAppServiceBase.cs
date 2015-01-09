using IEL.Estagio.Infra.Data.Interfaces;

namespace IEL.Estagio.Application.Interfaces
{
    public interface IAppServiceBase<TContext> where TContext : IDbContext
    {
        void BeginTransaction();
        void Commit();
    }
}