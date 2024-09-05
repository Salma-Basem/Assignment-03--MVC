using Company.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Interfaces
{
    internal interface IEmployeeRepository : IGenericRepository<Employee>, IEmployeeRepository
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

    }
}