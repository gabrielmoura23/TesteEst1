using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Repository;
using IEL.Estagio.Infra.Data.Context;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;


namespace IEL.Estagio.Infra.Data.Repositories
{
    public class EmpresaRepository : RepositoryBase<Empresa, IELEstagioContext>, IEmpresaRepository
    {
        public IEnumerable<Empresa> GetAll()
        {
            //return Context.Set<Empresa>().Include(t => t.Vaga).ToList();
            return Context.Set<Empresa>().ToList();

            //var a = (from e in Context.Set<Empresa>().Include(t => t.Vaga)
            //             select e);

            //return a.ToList();
        }
    }
}
