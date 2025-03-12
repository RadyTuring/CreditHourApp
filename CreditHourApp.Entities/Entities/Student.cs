using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Student
{
    public int Id { get; set; }
    public string StudentId { get; set; }
    //prefer adjust these after Complete functionality
    //[Required(ErrorMessage ="Ener the student Name"),Display(Name = "student Name"),Column(TypeName ="varcahar(50)")] 
    public string StudentName { get; set; }
    public int StudyYear { get; set; }
    public int? Nid { get; set; }
   
    public int? GenderId { get; set; }
    public Gender? Gender { get; set; }
    public DateTime Birthdate { get; set; }
    public int BirthdateLocationId { get; set; }
    public int NationalityId { get; set; }
    [ForeignKey("NationalityId")]
    public Nationlity? Nationlity { get; set; }
    public int StayId { get; set; }
    public string Phone { get; set; }
    public int SchoolTypeId { get; set; }
    public string SchoolName { get; set; }
    public double Score { get; set; }
    public double ScoreFull { get; set; }
    public DateTime CertificationDate { get; set; }
    public int? DepartmentId { get; set; }
    public Department? Department { get; set; }
}
