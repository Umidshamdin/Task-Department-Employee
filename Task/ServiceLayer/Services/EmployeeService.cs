using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Department;
using ServiceLayer.DTOs.Employee;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(EmployeeDto employeeDto)
        {
            var model = _mapper.Map<Employee>(employeeDto);
            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _repository.GetAsync(id);
            await _repository.DeleteAsync(employee);
        }

        public async Task<List<EmployeeDto>> GetAllAsync()
        {
            var model = await _repository.GetAllEmployeesByDepartments();
            var res = _mapper.Map<List<EmployeeDto>>(model);
            return res;
        }

        public async Task<EmployeeEditDto> GetAsync(int id)
        {
            var model = await _repository.GetAsync(id);
            var res = _mapper.Map<EmployeeEditDto>(model);
            return res;
        }

        //public Task<List<EmployeeVM>> GetByDepartmentIdAsync(int id)
        //{
        //    var model = _repository.GetEmployeesByDepartmentId(id);
        //    var res = _mapper.Map<List<EmployeeVM>>(model);
        //    return res;

        //}

        public async Task UpdateAsync(int Id, EmployeeEditDto employeeEditDto)
        {
            var entity = await _repository.GetAsync(Id);

            _mapper.Map(employeeEditDto, entity);

            await _repository.UpdateAsync(entity);
        }

        
    }
}
