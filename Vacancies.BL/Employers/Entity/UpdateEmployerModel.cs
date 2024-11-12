namespace Vacancies.BL.Employers.Entity;

public class UpdateEmployerModel
{
    public int Id { get; set; }

    public DateTime ModificationTime { get; set; }
    public DateTime CreationTime { get; set; }
    
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PasswordHash { get; set; }
    public string NameCompany { get; set; }
    public string CompanyWebsite { get; set; }
}