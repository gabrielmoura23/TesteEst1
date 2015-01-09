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
    public class EmpresaService : ServiceBase<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;
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

        public EmpresaService(
            IEmpresaRepository empresaRepository)
            : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public override Empresa GetById(Guid id)
        {
            return _empresaRepository.GetById(id);
        }

        public override IEnumerable<Empresa> GetAll()
        {
            var lemp = _empresaRepository.GetAll();
            return _empresaRepository.GetAll();
        }

        public override Empresa GetByIdTipoInteiro(int id)
        {
            return _empresaRepository.GetByIdTipoInteiro(id);
        }

        public ValidationResult AdicionarEmpresa(Empresa empresa)
        {
            var resultadoValidacao = new ValidationResult();

            //if (!empresa.IsValid())
            //{
            //    resultadoValidacao.AdicionarErro(empresa.ResultadoValidacao);
            //    return resultadoValidacao;
            //}

            base.Add(empresa);

            return resultadoValidacao;
        }
    }
}
