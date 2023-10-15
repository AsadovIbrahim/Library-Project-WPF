using Library_DB.Contexts;
using Library_DB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DB.Repositories.Concrets
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context = new LibraryDbContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Data is Null");
            _dbSet.Add(entity);
        }

        public void AddRange(ICollection<T> entities)
        {
            if (entities == null || entities.Count == 0) throw new ArgumentNullException("Data is Null");
            _dbSet.AddRange(entities);
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

       
        public T? GetById(int id)
        {
            return _dbSet.FirstOrDefault(p => p.Id == id);
        }

        public void Remove(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) throw new Exception("Data Yoxdur");

            _dbSet.Remove(entity);
        }

        public void Remove(int id)
        {
            var entity = _dbSet.FirstOrDefault(p => p.Equals(id));
            if (entity == null) throw new Exception("Data Yoxdur");

            _dbSet.Remove(entity);
        }
        public void Update(T entity)
        {
            var en = _dbSet.FirstOrDefault(p => p.Id == entity.Id);
            if (en == null) throw new Exception("Data Yoxdur");
            _dbSet.Update(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }

}
