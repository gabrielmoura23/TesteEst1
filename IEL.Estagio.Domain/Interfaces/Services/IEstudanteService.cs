using System.Collections.Generic;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Interfaces.Services
{
    public interface IEstudanteService : IServiceBase<Estudante>
    {
        ValidationResult AdicionarEstudante(Estudante estudante);
        IEnumerable<Estudante> BuscarPorNome(string nome);
    }
}
