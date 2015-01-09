using System.Collections.Generic;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.ValueObjects;
using System.Data;

namespace IEL.Estagio.Domain.Interfaces.Services
{
    public interface IVagaService : IServiceBase<Vaga>
    {
        ValidationResult AdicionarVaga(Vaga vaga);
        IEnumerable<Vaga> BuscarPorNome(string nome);

        dynamic getVagasDaEmpresa(int IdUnidadeLogado, int idEmpresa, string idStatusVaga);
        DataSet getVagasProEstudante(int IdUnidadeLogado, int codVaga, int idEstudante, string ativo);
    }
}
