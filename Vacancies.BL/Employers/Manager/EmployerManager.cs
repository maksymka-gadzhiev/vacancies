using AutoMapper;
using Vacancies.BL.Employers.Entity;
using Vacancies.DataAccess.Entities;
using Vacancies.Repository;

namespace Vacancies.BL.Employers.Manager;

public class EmployerManager : IEmployerManager
{
    private readonly IRepository<EmployerEntity> _employerRepository;
    private readonly IMapper _mapper;

    public EmployerManager(IRepository<EmployerEntity> employerRepository, IMapper mapper)
    {
        _employerRepository = employerRepository;
        _mapper = mapper;
    }
    public EmployerModel CreateEmployer(CreateEmployerModel model)
    {
        var entity = _mapper.Map<EmployerEntity>(model);
        entity = _employerRepository.Save(entity);
        return _mapper.Map<EmployerModel>(entity);
    }

    public void DeleteEmployer(int employerId)
    {
        var entity = _employerRepository.GetById(employerId);
        _employerRepository.Delete(entity);
    }

    public EmployerModel UpdateEmployer(UpdateEmployerModel model)
    {
        var entity = _mapper.Map<EmployerEntity>(model);
        entity = _employerRepository.Save(entity);
        return _mapper.Map<EmployerModel>(entity);
    }
}