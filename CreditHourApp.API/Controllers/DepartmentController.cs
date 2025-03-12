using CreditHourApp.API.BaseController;
using Data;
using Dtos;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditHourApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : MyBaseController
    {
        public DepartmentController(IUnitOfWork unitOfWork) : base(unitOfWork) 
        { 
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var res = await _unitOfWork.Departments.GetAllAsync();
            return Ok(res);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var res = await _unitOfWork.Departments.GetByIdAsync(id);
            return Ok(res);
        }
        [HttpPut("IsExist")]
        public async Task<IActionResult> IsExist(DepartmentDto dto)
        {
            var res =   _unitOfWork.Departments.IsExist(m=>m.DepartmentName.ToLower()==dto.DepartmentName.ToLower() || m.DepartmentCode.ToLower() == dto.DepartmentCode.ToLower());
            return Ok(res);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add(DepartmentDto dto)
        {
            var res = _unitOfWork.Departments.IsExist(m => m.DepartmentName.ToLower() == dto.DepartmentName.ToLower() );
            if(res)
            {
                return BadRequest("NDepartment Name already exist");
            }
              res = _unitOfWork.Departments.IsExist(m => m.DepartmentCode.ToLower() == dto.DepartmentCode.ToLower());
            if (res)
            {
                return BadRequest("CDepartment Code already exist");
            }
            Department department=new Department()
            {
                 DepartmentName=dto.DepartmentName,
                  DepartmentCode=dto.DepartmentCode
            };
             var resp = await _unitOfWork.Departments.AddAsync(department);
            _unitOfWork.Save();
            return Ok(department);
        }
        [HttpPut("Update")]
        public  IActionResult  Update(Department model)
        {
            var res =   _unitOfWork.Departments.Update(model);
            _unitOfWork.Save();
            return Ok(model);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(Department model)
        {
             _unitOfWork.Departments.Delete(model);
            _unitOfWork.Save();
            return Ok(model);
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteById(int id)
        {
            var _department =   _unitOfWork.Departments.GetById(id);
            _unitOfWork.Departments.Delete(_department);
            _unitOfWork.Save();
            return Ok(_department);
        }
    }
}
