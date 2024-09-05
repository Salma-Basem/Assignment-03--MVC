using Company.Repository.Repositories;
using Company.Service.Interfaces.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services.Employee
{
    internal class EmployeeService:IEmployeeService

    {
        public EmployeeService(EmployeeRepository departmentRepository) { }
        public void Add(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Interfaces.Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Interfaces.Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Models.Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Data.Models.Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Interfaces.Employee entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Interfaces.Employee> IEmployeeService.GetAll()
        {
            throw new NotImplementedException();
        }

        Interfaces.Employee IEmployeeService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
    }
}
