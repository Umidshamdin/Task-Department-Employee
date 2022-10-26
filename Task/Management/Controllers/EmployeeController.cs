using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Employee;
using ServiceLayer.Services.Interfaces;

namespace Management.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        private readonly IDepartmentService _departmentService;
        public EmployeeController(IEmployeeService service, IDepartmentService departmentService)
        {
            _service = service;
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllAsync());
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _departmentService.GetAllAsync();
            ViewBag.Departments = departments;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeCreateDto employeeDto)
        {
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.GetAllAsync();
                ViewBag.Departments = departments;
                return View();
            }

            await _service.CreateAsync(employeeDto);
            return Redirect("https://localhost:7126/Department/Detail/" + employeeDto.DepartmentId);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var result = await _service.GetAsync(id);
            var departments = await _departmentService.GetAllAsync();
            ViewBag.Departments = departments;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeEditDto employeeEditDto)
        {
            await _service.UpdateAsync(employeeEditDto.Id, employeeEditDto);
            return RedirectToAction(nameof(Index));
        }
    }
}
