using Api;
using Dtos;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Build.Framework;

namespace CreditHourApp.UI.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ICrudService _apiCall;

        public DepartmentController(ICrudService apiCall)
        {
            _apiCall = apiCall;
        }

        public async Task<IActionResult> Index()
        {
            var res = await _apiCall.GetAllAsync<Department>("Department/GetAll");
            return View(res);
        }
        public async Task<IActionResult> Create()
        {
            return View( );
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentDto dto)
        {
            if (ModelState.IsValid) 
            {
                var res = await _apiCall.CreateAsync ("Department/Add",dto);
                if(!res.IsSuccess)
                {
                    string _firstCharacter = res.ErrorMessage.Substring(1, 1).ToLower();
                    var msgError = res.ErrorMessage.Substring(2);
                    switch (_firstCharacter)
                    {
                        case "n":
                            ModelState.AddModelError("DepartmentName", msgError);
                            break;
                        case "c":
                            ModelState.AddModelError("DepartmentCode", msgError);
                            break;
                    }
                    return View(dto);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dto);
        }
    }
}
