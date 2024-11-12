using AutoMapper;
using Vacancies.BL.Employers.Entity;
using Vacancies.DataAccess.Entities;
using Vacancies.Repository;

namespace Vacancies.BL.Employers.Provider;

public class EmployerProvide
{
    private readonly IRepository<EmployerEntity> _employerRepository;
    private readonly IMapper _mapper;

    public EmployerProvide(IRepository<EmployerEntity> employerRepository, IMapper mapper)
    {
        _employerRepository = employerRepository;
        _mapper = mapper;
    }

    public IEnumerable<EmployerEntity> GetEmployers(FilterEmployerModel filter = null)
    {
        string? Email = filter?.Email;
        string? Name = filter?.Name;
        string? Surname = filter?.Surname;
        string? NameCompany = filter?.NameCompany;
        string? CompanyWebsite = filter?.CompanyWebsite;
        
        var Employers = _employerRepository.GetAll( emp =>
            (Email == null || emp.Email.Contains(Email)) && 
            (Name == null || emp.Name.Contains(Name)) &&
            (Surname == null || emp.Surname.Contains(Surname)) &&
            (NameCompany == null || emp.NameCompany.Contains(NameCompany)) &&
            (CompanyWebsite == null || emp.CompanyWebsite.Contains(CompanyWebsite)));
        return _mapper.Map<IEnumerable<EmployerEntity>>(Employers);
    }
}