using Vacancies.BL.Employers.Entity;

namespace Vacancies.BL.Employers.Provider;

public interface IEmployerProvide
{
    IEnumerable<EmployerModel> GetEmployers(FilterEmployerModel filter = null);
    EmployerModel GetEmployer(Guid id);
}