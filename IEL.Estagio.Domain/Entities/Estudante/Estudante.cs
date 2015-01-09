using System;
using System.Collections.Generic;
using IEL.Estagio.Domain.Interfaces.Validation;
using IEL.Estagio.Domain.Validation.Estudantes;
using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Entities
{
    public class Estudante : ISelfValidator
    {
        public Estudante()
        {
            EstudanteId = Guid.NewGuid();
        }

        public Guid EstudanteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            var fiscal = new EstudanteEstaAptoParaCadastroNoSistema();

            ResultadoValidacao = fiscal.Validar(this);

            return ResultadoValidacao.IsValid;
        }
    }
}
