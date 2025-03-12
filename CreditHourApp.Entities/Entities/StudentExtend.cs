using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Entities;

public class StudentExtend
{
    public int Id { get; set; }
    public string StudentId { get; set; }

    // Father's Information
    public string FatherName { get; set; }
    public string FatherJob { get; set; }
    public int FatherNationalityId { get; set; }
    public string FatherPhone { get; set; }
    public string FatherEmail { get; set; }
    public string FatherNid { get; set; }
    public string FatherLoc { get; set; }

    // Mother's Information
    public string MotherName { get; set; }
    public string MotherJob { get; set; }
    public int MotherNationalityId { get; set; }
    public string MotherPhone { get; set; }
    public string MotherEmail { get; set; }
    public string? MotherNid { get; set; }
    public string? MotherLoc { get; set; }

    // Suggestions
    public string SuggestInfoPos { get; set; }
    public string SuggestInfoNeg { get; set; }
}
