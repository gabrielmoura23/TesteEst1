using System.Data.Entity;
using IEL.Estagio.Infra.Data.Interfaces;

namespace IEL.Estagio.Infra.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string nameOrConnectionString) 
            :base(nameOrConnectionString)
        {

        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}