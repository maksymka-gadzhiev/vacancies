namespace Vacancies.DataAccess.Entities;

public class ApplicantEntity : BaseEntity
{  
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PasswordHash { get; set; }
    
    public List<ResumeEntity> Resumes { get; set; }
}