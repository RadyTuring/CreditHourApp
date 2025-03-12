 

namespace  Dtos;

public class StudentDto
{
    public string StudentId { get; set; }
    public string StudentName { get; set; }
    public int StudyYear { get; set; }
    public int? Nid { get; set; }

    public int? GenderId { get; set; }
    
    public DateTime Birthdate { get; set; }
    public int BirthdateLocationId { get; set; }
    public int NationalityId { get; set; }
    
    public int StayId { get; set; }
    public string Phone { get; set; }
    public int SchoolTypeId { get; set; }
    public string SchoolName { get; set; }
    public double Score { get; set; }
    public double ScoreFull { get; set; }
    public DateTime CertificationDate { get; set; }
    public int? DepartmentId { get; set; }
    
}
