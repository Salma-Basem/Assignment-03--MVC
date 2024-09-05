using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Interfaces.Employee
{
    internal interface IEmployeeService
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Add(Employee entity);
        void Update(Employee entity);
        void Delete(Employee entity);
    }
}
