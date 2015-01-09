using System.Collections.Generic;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.ValueObjects;
using System.Data;

namespace IEL.Estagio.Domain.Interfaces.Services
{
    public interface IEmpresaService : IServiceBase<Empresa>
    {
        ValidationResult AdicionarEmpresa(Empresa empresa);
    }
}
