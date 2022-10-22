﻿using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Employee> entities;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<Employee>();
        }
        public async Task<IEnumerable<Employee>> GetEmployeesByDepartmentId(int departmentId)
        {
            return await entities.Where(x => x.DepartmentId == departmentId).ToListAsync();
        }
        public async Task<List<Employee>> GetAllEmployeesByDepartments()
        {
            return await entities.Where(c => c.SoftDelete == false).Include(c => c.Department).ToListAsync();
        }
    }
}
