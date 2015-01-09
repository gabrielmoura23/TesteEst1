using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Specification.Vagas;
using IEL.Estagio.Domain.Validation.Base;

namespace IEL.Estagio.Domain.Validation.Vagas
{
    public class VagaAptoParaCadastroNoSistema : FiscalBase<Vaga>
    {
        public VagaAptoParaCadastroNoSistema()
        {
            var vagaFormandos = new VagaComEstudanteFormando();
            //var clienteAtivo = new ClientePossuiStatusAtivo();
            //var clienteCPFValido = new ClientePossuiCPFValido();

            base.AdicionarRegra("vagaFormandos", new Regra<Vaga>(vagaFormandos, "Estudante formado?"));
            //base.AdicionarRegra("ClienteAtivo", new Regra<Cliente>(clienteAtivo, "Cliente não está ativo no sistema"));
            //base.AdicionarRegra("ClienteCPFValido", new Regra<Cliente>(clienteCPFValido, "Cliente informou um CPF Inválido"));
        }
    }
}
