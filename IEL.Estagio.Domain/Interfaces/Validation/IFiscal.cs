using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Interfaces.Validation
{
    public interface IFiscal<in TEntity>
    {
        ValidationResult Validar(TEntity entity);
    }
}
