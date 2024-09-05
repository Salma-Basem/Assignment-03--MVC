using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services.Department
{
    internal class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository )
        {
            _departmentRepository = departmentRepository;
        }
        public void Add(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Data.Models.Department> GetAll()
        {
            var departments= _departmentRepository.GetAll();
            return departments;
        }

        public Data.Models.Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Data.Models.Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
