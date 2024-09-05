﻿using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        public EmployeeRepository(CompanyDbContext context) : base(context) { }
        //{
        //    _context = context;
        //}
        //public void Add(Employee employee)
        //{
        //    _context.Employees.Add(employee);
        //}

        //public void Delete(Employee employee)
        //{
        //    _context.Employees.Remove(employee);
        //}

        //public IEnumerable<Employee> GetAll()
        //{
        //    return _context.Employees.ToList();

        //}


        //public Employee GetById(int id)
        //{
        //    return _context.Employees.FirstOrDefault(x => x.Id == id);
        //}

        //public void Update(Employee employee)
        //{
        //    _context.Employees.Update(employee);
        //}

        //{
        //    _context = context;
        //}
        //public void Add(Employee employee)
        //{
        //    _context.Employees.Add(employee);
        //}
    }
}
