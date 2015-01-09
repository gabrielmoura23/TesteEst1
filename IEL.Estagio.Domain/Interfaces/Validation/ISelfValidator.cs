using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Interfaces.Validation
{
    public interface ISelfValidator
    {
        ValidationResult ResultadoValidacao { get; }
        bool IsValid(); 
    }
}