using System;
using System.Collections.Generic;
using System.Linq;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Repository;
//using IEL.Estagio.Domain.Interfaces.Repository.ADO;
//using IEL.Estagio.Domain.Interfaces.Repository.ReadOnly;
using IEL.Estagio.Domain.Interfaces.Services;
using IEL.Estagio.Domain.ValueObjects;

namespace IEL.Estagio.Domain.Services
{
    public class EstudanteService : ServiceBase<Estudante>, IEstudanteService
    {
        private readonly IEstudanteRepository _estudanteRepository;
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

        public EstudanteService(
            IEstudanteRepository estudanteRepository)
            : base(estudanteRepository)
        {
            _estudanteRepository = estudanteRepository;
        }

        public override Estudante GetById(Guid id)
        {
            return _estudanteRepository.GetById(id);
        }

        public override IEnumerable<Estudante> GetAll()
        {
            return _estudanteRepository.GetAll();
        }

        public IEnumerable<Estudante> BuscarPorNome(string nome)
        {
            return _estudanteRepository.BuscarPorNome(nome);
        }

        public ValidationResult AdicionarEstudante(Estudante estudante)
        {
            var resultadoValidacao = new ValidationResult();

            if (!estudante.IsValid())
            {
                resultadoValidacao.AdicionarErro(estudante.ResultadoValidacao);
                return resultadoValidacao;
            }

            base.Add(estudante);

            return resultadoValidacao;
        }
    }
}
