using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Repository;
using IEL.Estagio.Infra.Data.Context;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace IEL.Estagio.Infra.Data.Repositories
{
    public class VagaRepository : RepositoryBase<Vaga, IELEstagioContext>, IVagaRepository
    {
        public IEnumerable<Vaga> BuscarPorNome(string nome)
        {
            return base.Find(c => c.bairro == nome);
        }

        public dynamic getVagasDaEmpresa(int idUnidadeLogado, int idEmpresa, string idStatusVaga)
        {
            //usar lazy loading com lambda seria melhor (testar)



            var a = (from vaga in Context.Set<Vaga>()
                     where vaga.idunidade == idUnidadeLogado
                         && vaga.idempresa == idEmpresa
                         && vaga.flg_ativo == "S"
                     select new
                     {
                         IDVAGA = vaga.idvaga,
                     }
                ).OrderByDescending(t => t.IDVAGA);

            return a.ToList();
        }

        public DataSet getVagasProEstudante(int IdUnidadeLogado, int codVaga, int idEstudante, string ativo)
        {
            throw new System.NotImplementedException();
        }
    }
}
