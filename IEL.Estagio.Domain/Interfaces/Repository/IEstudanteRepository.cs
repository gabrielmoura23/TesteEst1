using IEL.Estagio.Domain.Entities;
using System.Collections.Generic;

namespace IEL.Estagio.Domain.Interfaces.Repository
{
    public interface IEstudanteRepository : IRepositoryBase<Estudante>
    {
        IEnumerable<Estudante> BuscarPorNome(string nome);
    }
}
