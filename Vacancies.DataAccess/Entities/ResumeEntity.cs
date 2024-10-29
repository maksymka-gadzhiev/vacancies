namespace Vacancies.DataAccess.Entities;

public class ResumeEntity : BaseEntity
{
    public string Education { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }
    public string AdditionalInformation { get; set; }
    
    public int ApplicantId { get; set; }
    public ApplicantEntity ApplicantEntity { get; set; }
    
    public List<ResponseEntity> Responses { get; set; }
}