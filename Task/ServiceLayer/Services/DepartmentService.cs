using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Department;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IEmployeeService _employeeService;

        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository repository, IMapper mapper, IEmployeeService employeeService)
        {
            _repository = repository;
            _mapper = mapper;
            _employeeService = employeeService;
        }


        public async Task CreateAsync(DepartmentDto departmentDto)
        {
            var model = _mapper.Map<Department>(departmentDto);
            if(departmentDto.ParentDepartmentId != null)
            {
                var parrent = await _repository.GetAsync(departmentDto.ParentDepartmentId);
                model.ParentDepartment = parrent;
            }
            else
            {
                model.ParentDepartment = null;
            }
            
            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            var department = await _repository.GetDepartmentById(id);


            if (department != null)
            {
                foreach (var employee in department.Employees)
                {
                    await _employeeService.DeleteAsync(employee.Id);
                }

            }
            await _repository.DeleteAsync(department);
        }

        public async Task<List<DepartmentDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<DepartmentDto>>(model);
            return res;
        }

        public async Task UpdateAsync(int Id, DepartmentEditDto departmentEditDto)
        {
            var model = _mapper.Map<Department>(departmentEditDto);
            if (departmentEditDto.ParentDepartmentId != null)
            {
                var parrent = await _repository.GetAsync(departmentEditDto.ParentDepartmentId);
                model.ParentDepartment = parrent;
            }
            else
            {
                model.ParentDepartment = null;
            }

            await _repository.UpdateAsync(model);
        }


        public async Task<DepartmentEditDto> GetByIdAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var res = _mapper.Map<DepartmentEditDto>(model);
            return res;
        }

        public async Task<DepartmentDto> Detail(int id)
        {
            var entity = await _repository.GetDepartmentDetail(id);
            return _mapper.Map<DepartmentDto>(entity);
        }
    }
}
