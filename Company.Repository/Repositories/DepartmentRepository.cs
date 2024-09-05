using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    internal class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly CompanyDbContext _context;
        public DepartmentRepository(CompanyDbContext context) : base(context) { }
        //  {
        //    _context = context;
        //}
        //public void Add(Department department)
        //{
        //    _context.Departments.Add(department);
        //}

        //public void Delete(Department department)
        //{
        //    _context.Departments.Remove(department);

        //}

        //public IEnumerable<Department> GetAll()
        //{
        //    return _context.Departments.ToList();
        //}

        //public Department GetById(int id)
        //{
        // return _context.Departments.FirstOrDefault(x => x.Id == id);


        //}
        //public void Update(Department department)
        //{
        //    _context.Departments.Update(department);
        //}
    
}
    }
