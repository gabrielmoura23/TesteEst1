using AutoMapper;
using IEL.Estagio.Application.ViewModels;
using IEL.Estagio.Domain.Entities;

namespace IEL.Estagio.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Estudante, EstudanteViewModel>();
            Mapper.CreateMap<Vaga, VagaViewModel>();
            Mapper.CreateMap<Empresa, EmpresaViewModel>();
        }
    }
}