namespace Vacancies.DataAccess.Entities;

public class VacancyEntity : BaseEntity
{
    public string Description { get; set; }
    public DateTime DatePublication { get; set; }
    public int Experience { get; set; }
    public string NeedSkills { get; set; }
    public int Salary { get; set; }
    
    public int EmployerId { get; set; }
    public EmployerEntity EmployerEntity { get; set; }
    
    public int ResponseId { get; set; }
    public ResponseEntity ResponseEntity { get; set; }
    
    public List<ResponseEntity> Responses { get; set; }
}