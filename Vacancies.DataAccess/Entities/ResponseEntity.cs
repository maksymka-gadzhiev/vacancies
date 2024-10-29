namespace Vacancies.DataAccess.Entities;

public class ResponseEntity : BaseEntity
{
    public DateTime DateResponse { get; set; }
    
    public int ResumeId { get; set; }
    public ResumeEntity ResumeEntity { get; set; }
    
    public List<VacancyEntity> Vacancies { get; set; }
}