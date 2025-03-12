
using System.ComponentModel.DataAnnotations;

namespace  Dtos;

public class DepartmentDto
{
    [Required(ErrorMessage = "Please Enter The Department Name "),Display(Name = "Department Name")]
    public string DepartmentName { get; set; }
    [Required(ErrorMessage = "Please Enter The Department Code "), Display(Name = "Department Code"),MinLength(5,ErrorMessage ="The length should be 5 Characters at least")]
    public string DepartmentCode { get; set; }
}
