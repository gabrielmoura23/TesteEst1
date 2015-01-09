using System;
using System.Collections.Generic;
using IEL.Estagio.Application.Validation;
using IEL.Estagio.Application.ViewModels;

namespace IEL.Estagio.Application.Interfaces
{
    public interface IEmpresaAppService : IDisposable
    {
        ValidationAppResult Add(EmpresaViewModel vagaViewModel);
        EmpresaViewModel GetById(Guid id);
        EmpresaViewModel GetByIdTipoInteiro(int id);
        IEnumerable<EmpresaViewModel> GetAll();
        void Update(EmpresaViewModel vagaViewModel);
        void Remove(EmpresaViewModel vagaViewModel);
    }
}
