using Company.Data.Contexts;
using Company.Data.Models;
using Company.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;



namespace Company.Repository.Repositories
{
    internal class GenericRepsoitory<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly CompanyDbContext _context;
        public GenericRepsoitory(CompanyDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);

        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
          
       

            public IEnumerable<T> GetAll()
            {
                return _context.Set<T>().ToList();
            }

            public T GetById(int id)
            {
                return _context.Set<T>().FirstOrDefault(x => x.Id == id);

            }
            public void Update(T entity)
            {
                _context.Set<T>().Update(entity);

            }

        } 
    }

           
       