using Vacancies.BL.Employers.Entity;

namespace Vacancies.BL.Employers.Manager;

public interface IEmployerManager
{
    EmployerModel CreateEmployer(CreateEmployerModel model);
    void DeleteEmployer(int employerId);
    EmployerModel UpdateEmployer(UpdateEmployerModel model);
}