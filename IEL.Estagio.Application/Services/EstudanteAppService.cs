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
    public class EstudanteAppService : AppServiceBase<IELEstagioContext>, IEstudanteAppService
    {
        private readonly IEstudanteService _estudanteService;

        public EstudanteAppService(IEstudanteService estudanteService)
        {
            _estudanteService = estudanteService;
        }

        public ValidationAppResult Add(EstudanteViewModel estudanteViewModel)
        {
            var model = Mapper.Map<EstudanteViewModel, Estudante>(estudanteViewModel);

            BeginTransaction();

            var result = _estudanteService.AdicionarEstudante(model);
            if (!result.IsValid)
                return DomainToApplicationResult(result);

            Commit();

            return DomainToApplicationResult(result);
        }

        public EstudanteViewModel GetById(Guid id)
        {
            return Mapper.Map<Estudante, EstudanteViewModel>(_estudanteService.GetById(id));
        }

        public IEnumerable<EstudanteViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Estudante>, IEnumerable<EstudanteViewModel>>(_estudanteService.GetAll());
        }

        public IEnumerable<EstudanteViewModel> BuscarPorNome(string nome)
        {
            return Mapper.Map<IEnumerable<Estudante>, IEnumerable<EstudanteViewModel>>(_estudanteService.BuscarPorNome(nome));
        }

        public void Update(EstudanteViewModel estudanteViewModel)
        {
            var model = Mapper.Map<EstudanteViewModel, Estudante>(estudanteViewModel);

            BeginTransaction();
            _estudanteService.Update(model);
            Commit();
        }

        public void Remove(EstudanteViewModel estudanteViewModel)
        {
            var model = Mapper.Map<EstudanteViewModel, Estudante>(estudanteViewModel);

            BeginTransaction();
            _estudanteService.Remove(model);
            Commit();
        }

        public void Dispose()
        {
            _estudanteService.Dispose();
        }
    }
}
