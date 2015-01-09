using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using IEL.Estagio.Application.Interfaces;
using IEL.Estagio.Application.Validation;
using IEL.Estagio.Application.ViewModels;
using IEL.Estagio.Domain.Entities;
using IEL.Estagio.Domain.Interfaces.Services;
using IEL.Estagio.Infra.Data.Context;

namespace IEL.Estagio.Application.Services
{
    public class EmpresaAppService : AppServiceBase<IELEstagioContext>, IEmpresaAppService
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaAppService(IEmpresaService vagaService)
        {
            _empresaService = vagaService;
        }

        public ValidationAppResult Add(EmpresaViewModel EmpresaViewModel)
        {
            var model = Mapper.Map<EmpresaViewModel, Empresa>(EmpresaViewModel);

            BeginTransaction();

            var result = _empresaService.AdicionarEmpresa(model);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            Commit();

            return DomainToApplicationResult(result);
        }

        public EmpresaViewModel GetById(Guid id)
        {
            return Mapper.Map<Empresa, EmpresaViewModel>(_empresaService.GetById(id));
        }

        public IEnumerable<EmpresaViewModel> GetAll()
        {
            _empresaService.GetAll();
            return Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaService.GetAll());
        }

        public void Update(EmpresaViewModel EmpresaViewModel)
        {
            var model = Mapper.Map<EmpresaViewModel, Empresa>(EmpresaViewModel);

            BeginTransaction();
            _empresaService.Update(model);
            Commit();
        }

        public void Remove(EmpresaViewModel EmpresaViewModel)
        {
            var model = Mapper.Map<EmpresaViewModel, Empresa>(EmpresaViewModel);

            BeginTransaction();
            _empresaService.Remove(model);
            Commit();
        }

        public void Dispose()
        {
            _empresaService.Dispose();
        }

        public EmpresaViewModel GetByIdTipoInteiro(int id)
        {
            return Mapper.Map<Empresa, EmpresaViewModel>(_empresaService.GetByIdTipoInteiro(id));
        }
    }
}
