using AutoMapper;
using IEL.Estagio.Application.ViewModels;
using IEL.Estagio.Domain.Entities;

namespace IEL.Estagio.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<EstudanteViewModel, Estudante>();
            Mapper.CreateMap<VagaViewModel, Vaga>();
            Mapper.CreateMap<EmpresaViewModel, Empresa>();
        }
    }
}