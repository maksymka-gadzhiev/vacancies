namespace Vacancies.DataAccess.Entities;

public class EmployerEntity : BaseEntity
{
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PasswordHash { get; set; }
    public string NameCompany { get; set; }
    public string CompanyWebsite { get; set; }
    
    public List<VacancyEntity> Vacancies { get; set; }
}