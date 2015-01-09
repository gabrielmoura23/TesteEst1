using System;
using System.Collections.Generic;
using System.Linq;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Repository;
//using IEL.Estagio.Domain.Interfaces.Repository.ADO;
//using IEL.Estagio.Domain.Interfaces.Repository.ReadOnly;
using IEL.Estagio.Domain.Interfaces.Services;
using IEL.Estagio.Domain.ValueObjects;
using System.Data;

namespace IEL.Estagio.Domain.Services
{
    public class VagaService : ServiceBase<Vaga>, IVagaService
    {
        private readonly IVagaRepository _vagaRepository;
        //private readonly IEstudanteReadOnlyRepository _estudanteReadOnlyRepository;
        //private readonly IEstudanteADORepository _estudanteAdoRepository;

        //public EstudanteService(
        //    IEstudanteRepository estudanteRepository, 
        //    IClienteReadOnlyRepository clienteReadOnlyRepository, 
        //    IClienteADORepository clienteAdoRepository)
        //    : base(clienteRepository)
        //{
        //    _estudanteRepository = estudanteRepository;
        //    _estudanteReadOnlyRepository = clienteReadOnlyRepository;
        //    _estudanteAdoRepository = clienteAdoRepository;
        //}

        public VagaService(
            IVagaRepository vagaRepository)
            : base(vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public override Vaga GetById(Guid id)
        {
            return _vagaRepository.GetById(id);
        }

        public override IEnumerable<Vaga> GetAll()
        {
            return _vagaRepository.GetAll();
        }

        public IEnumerable<Vaga> BuscarPorNome(string nome)
        {
            return _vagaRepository.BuscarPorNome(nome);
        }

        public ValidationResult AdicionarVaga(Vaga vaga)
        {
            var resultadoValidacao = new ValidationResult();

            if (!vaga.IsValid())
            {
                resultadoValidacao.AdicionarErro(vaga.ResultadoValidacao);
                return resultadoValidacao;
            }

            base.Add(vaga);

            return resultadoValidacao;
        }


        public dynamic getVagasDaEmpresa(int IdUnidadeLogado, int idEmpresa, string idStatusVaga)
        {
            return _vagaRepository.getVagasDaEmpresa(IdUnidadeLogado, idEmpresa, idStatusVaga);
        }

        public DataSet getVagasProEstudante(int IdUnidadeLogado, int codVaga, int idEstudante, string ativo)
        {
            throw new NotImplementedException();
        }

        public override Vaga GetByIdTipoInteiro(int id)
        {
            return _vagaRepository.GetByIdTipoInteiro(id);
        }
    }
}
