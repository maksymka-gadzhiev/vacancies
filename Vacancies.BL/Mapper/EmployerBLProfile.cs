using AutoMapper;
using Vacancies.BL.Employers.Entity;
using Vacancies.DataAccess.Entities;

namespace Vacancies.BL.Mapper;

public class EmployerBLProfile : Profile
{
    public EmployerBLProfile()
    {
        CreateMap<EmployerEntity, EmployerModel>()
            .ForMember(x => x.Id, y => y.MapFrom(src => src.Id));
        CreateMap<CreateEmployerModel, EmployerModel>()
            .ForMember(x => x.Id, y => y.Ignore())
            .ForMember(x => x.CreationTime, y => y.Ignore())
            .ForMember(x => x.ModificationTime, y => y.Ignore());
        
        CreateMap<UpdateEmployerModel, EmployerModel>()
            .ForMember(x => x.Id, y => y.MapFrom(src => src.Id))
            .ForMember(x => x.ModificationTime, y => y.Ignore());
    }
}