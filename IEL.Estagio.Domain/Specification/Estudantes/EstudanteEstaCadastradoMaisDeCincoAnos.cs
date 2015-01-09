using System;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Specification;

namespace IEL.Estagio.Domain.Specification.Estudantes
{
    class EstudanteEstaCadastradoMaisDeCincoAnos : ISpecification<Estudante>
    {
        public bool IsSatisfiedBy(Estudante estudante)
        {
            return DateTime.Now.Year - estudante.DataCadastro.Year >= 5;
        }
    }
}
