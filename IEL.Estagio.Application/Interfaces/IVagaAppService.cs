using System;
using System.Collections.Generic;
using IEL.Estagio.Application.Validation;
using IEL.Estagio.Application.ViewModels;

namespace IEL.Estagio.Application.Interfaces
{
    public interface IVagaAppService : IDisposable
    {
        ValidationAppResult Add(VagaViewModel vagaViewModel);
        VagaViewModel GetById(Guid id);
        VagaViewModel GetByIdTipoInteiro(int id);
        IEnumerable<VagaViewModel> GetAll();
        void Update(VagaViewModel vagaViewModel);
        void Remove(VagaViewModel vagaViewModel);
        IEnumerable<VagaViewModel> BuscarPorNome(string nome);

        dynamic getVagasDaEmpresa(int IdUnidadeLogado, int idEmpresa, string idStatusVaga);
    }
}
