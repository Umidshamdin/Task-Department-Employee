using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Department;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;

namespace Management.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _service;
        public DepartmentController(DepartmentService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllAsync();
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(DepartmentDto departmentDto)
        {


            await _service.CreateAsync(departmentDto);
            return RedirectToAction(nameof(Index));

            return View(departmentDto);
        }
    }
}
