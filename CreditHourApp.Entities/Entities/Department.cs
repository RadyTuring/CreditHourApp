using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class Department
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Please Enter The Department Name "), Display(Name = "Department Name")]
    public string DepartmentName { get; set; }
    [Required(ErrorMessage = "Please Enter The Department Code "), Display(Name = "Department Code"), MinLength(5, ErrorMessage = "The length should be 5 Characters at least")]
    public string DepartmentCode { get; set; }
}
