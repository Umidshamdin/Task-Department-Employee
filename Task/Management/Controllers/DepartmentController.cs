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
        public DepartmentController(IDepartmentService service)
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
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(DepartmentDto departmentDto)
        {
            //if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid) return View();
            if (!ModelState.IsValid) return View();
            await _service.CreateAsync(departmentDto);
            return RedirectToAction(nameof(Index));           
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }     
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _service.GetByIdAsync(id);   
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentEditDto departmentEditDto)
        {
                await _service.UpdateAsync(departmentEditDto.Id, departmentEditDto);
                return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var detail = await _service.Detail(id);
            return View(detail);
        }
    }
}
