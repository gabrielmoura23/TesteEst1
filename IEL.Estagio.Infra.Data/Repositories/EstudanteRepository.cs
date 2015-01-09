using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Repository;
using IEL.Estagio.Infra.Data.Context;
using System.Collections.Generic;

namespace IEL.Estagio.Infra.Data.Repositories
{
    public class EstudanteRepository : RepositoryBase<Estudante, IELEstagioContext>, IEstudanteRepository
    {
        public IEnumerable<Estudante> BuscarPorNome(string nome)
        {
            return base.Find(c => c.Nome == nome);
        }
    }
}
