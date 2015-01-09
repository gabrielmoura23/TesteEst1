using System;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Specification;

namespace IEL.Estagio.Domain.Specification.Vagas
{
    class VagaComEstudanteFormando : ISpecification<Vaga>
    {
        public bool IsSatisfiedBy(Vaga vaga)
        {
            return !string.IsNullOrEmpty(vaga.flg_permite_formandos);
        }
    }
}
