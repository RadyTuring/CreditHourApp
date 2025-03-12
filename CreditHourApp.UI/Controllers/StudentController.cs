using Api;
using Dtos;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace CreditHourApp.UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly ICrudService _apiCall;

        public StudentController(ICrudService apiCall)
        {
            _apiCall = apiCall;
        }

        public async Task<IActionResult> Index()
        {
            var res = await _apiCall.GetAllAsync<Student>("Student/GetAllByDepartment?id=1");
            return View(res);
        }

        public async Task<IActionResult> Create()
        {
            return View( );
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentDto dto)
        {
            if (ModelState.IsValid)
            {
                var res = await _apiCall.CreateAsync("Student/Add", dto);
                if (res.IsSuccess)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(dto);
          
        }


        public async Task<IActionResult> GetAllByDepartment(int id)
        {
            var res = await _apiCall.GetAllAsync<Student>($"Student/GetAllByDepartment?id={id}");
            return Json(res);
        }
    }
}
