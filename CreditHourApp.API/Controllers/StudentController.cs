using CreditHourApp.API.BaseController;
using Dtos;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CreditHourApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : MyBaseController
    {
        public StudentController(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var res = await _unitOfWork.Students.GetAllAsync();
            return Ok(res);
        }

        [HttpGet("GetAllByDepartment")]
        public async Task<IActionResult> GetAllByDepartment(int id)
        {
            var res = await _unitOfWork.Students.FindAllAsync(m => m.DepartmentId == id);
            return Ok(res);
        }
        [HttpGet("GetAllByDepartmentPagination")]
        public async Task<IActionResult> GetAllByDepartmentPagination(int id)
        {
            var res = await _unitOfWork.Students.FindAllAsync(m => m.DepartmentId == id, 2, 2);
            return Ok(res);
        }
        [HttpGet("GetAllByDepartmentWithNames")]
        public async Task<IActionResult> GetAllByDepartmentWithNames(int id)
        {
            var res = await _unitOfWork.Students.FindAllAsync(m => m.DepartmentId == id, new string[] { "Nationlity", "Department" });
            return Ok(res);
        }
        [HttpGet("GetStudentByCode")]
        public async Task<IActionResult> GetStudentByCode(string studentId)
        {
            var res = await _unitOfWork.Students.FindAsync(m => m.StudentId == studentId, new string[] { "Nationlity", "Department" });
            return Ok(res);
        }
        [HttpGet("GetStudentCount")]
        public async Task<IActionResult> GetStudentCount()
        {
            var res = await _unitOfWork.Students.CountAsync();
            return Ok(res);
        }
        [HttpGet("GetStudentCountByDepartment")]
        public async Task<IActionResult> GetStudentCountByDepartment(int id)
        {
            var res = await _unitOfWork.Students.CountAsync(m => m.DepartmentId == id);
            return Ok(res);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(StudentDto dto)
        {
            //validate
            Student student = new Student()
            {
                StudentId = dto.StudentId,
                StudentName = dto.StudentName,
                Birthdate = dto.Birthdate,
                BirthdateLocationId = dto.BirthdateLocationId,
                CertificationDate = dto.CertificationDate,
                DepartmentId = dto.DepartmentId,
                GenderId = dto.GenderId,
                NationalityId = dto.NationalityId,
                Nid = dto.Nid,
                Phone = dto.Phone,
                SchoolTypeId = dto.SchoolTypeId,
                SchoolName = dto.SchoolName,
                Score = dto.Score,
                ScoreFull = dto.ScoreFull,
                StayId = dto.StayId,
                StudyYear = dto.StudyYear,
                 
            };
            var resp = await _unitOfWork.Students.AddAsync(student);
            _unitOfWork.Save();
            return Ok(student);
            
        }

    }
}
