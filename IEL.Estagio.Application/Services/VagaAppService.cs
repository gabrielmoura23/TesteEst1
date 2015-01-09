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
    public class VagaAppService : AppServiceBase<IELEstagioContext>, IVagaAppService
    {
        private readonly IVagaService _vagaService;

        public VagaAppService(IVagaService vagaService)
        {
            _vagaService = vagaService;
        }

        public ValidationAppResult Add(VagaViewModel vagaViewModel)
        {
            var model = Mapper.Map<VagaViewModel, Vaga>(vagaViewModel);

            BeginTransaction();

            var result = _vagaService.AdicionarVaga(model);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            Commit();

            return DomainToApplicationResult(result);
        }

        public VagaViewModel GetById(Guid id)
        {
            return Mapper.Map<Vaga, VagaViewModel>(_vagaService.GetById(id));
        }

        public IEnumerable<VagaViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Vaga>, IEnumerable<VagaViewModel>>(_vagaService.GetAll());
        }

        public IEnumerable<VagaViewModel> BuscarPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Vaga>, IEnumerable<VagaViewModel>>(_vagaService.BuscarPorNome(nome));
        }

        public void Update(VagaViewModel vagaViewModel)
        {
            var model = Mapper.Map<VagaViewModel, Vaga>(vagaViewModel);

            BeginTransaction();
            _vagaService.Update(model);
            Commit();
        }

        public void Remove(VagaViewModel vagaViewModel)
        {
            var model = Mapper.Map<VagaViewModel, Vaga>(vagaViewModel);

            BeginTransaction();
            _vagaService.Remove(model);
            Commit();
        }

        public void Dispose()
        {
            _vagaService.Dispose();
        }


        public dynamic getVagasDaEmpresa(int IdUnidadeLogado, int idEmpresa, string idStatusVaga)
        {
            return Mapper.Map<dynamic, dynamic>(_vagaService.getVagasDaEmpresa(IdUnidadeLogado, idEmpresa, idStatusVaga));
        }

        public VagaViewModel GetByIdTipoInteiro(int id)
        {
            return Mapper.Map<Vaga, VagaViewModel>(_vagaService.GetByIdTipoInteiro(id));
        }
    }
}
