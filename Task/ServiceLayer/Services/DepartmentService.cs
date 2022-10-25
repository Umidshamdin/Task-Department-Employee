using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Department;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(DepartmentDto departmentDto)
        {
            var model = _mapper.Map<Department>(departmentDto);
            await _repository.CreateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _repository.GetAsync(id);
            await _repository.DeleteAsync(student);
        }

        public async Task<List<DepartmentDto>> GetAllAsync()
        {
            var model = await _repository.GetAllAsync();
            var res = _mapper.Map<List<DepartmentDto>>(model);
            return res;
        }

        public async Task UpdateAsync(int Id, DepartmentEditDto departmentEditDto)
        {
            var entity = await _repository.GetAsync(Id);

            _mapper.Map(departmentEditDto, entity);

            await _repository.UpdateAsync(entity);
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
