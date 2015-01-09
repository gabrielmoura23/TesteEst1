using IEL.Estagio.Domain.Entities;
using System.Collections.Generic;
using System.Data;

namespace IEL.Estagio.Domain.Interfaces.Repository
{
    public interface IVagaRepository : IRepositoryBase<Vaga>
    {
        IEnumerable<Vaga> BuscarPorNome(string nome);
        dynamic getVagasDaEmpresa(int IdUnidadeLogado, int idEmpresa, string idStatusVaga);
        DataSet getVagasProEstudante(int IdUnidadeLogado, int codVaga, int idEstudante, string ativo);
    }
}
