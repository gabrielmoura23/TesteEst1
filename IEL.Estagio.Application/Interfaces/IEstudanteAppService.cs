using System;
using System.Collections.Generic;
using IEL.Estagio.Application.Validation;
using IEL.Estagio.Application.ViewModels;

namespace IEL.Estagio.Application.Interfaces
{
    public interface IEstudanteAppService : IDisposable
    {
        ValidationAppResult Add(EstudanteViewModel estudanteViewModel);
        EstudanteViewModel GetById(Guid id);
        IEnumerable<EstudanteViewModel> GetAll();
        void Update(EstudanteViewModel estudanteViewModel);
        void Remove(EstudanteViewModel estudanteViewModel);
        IEnumerable<EstudanteViewModel> BuscarPorNome(string nome);
    }
}
