using ClassLibrary2.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Services
{
    public class MyGenericRepository<TEntity> where TEntity : class
    {
        private MyContext _context;
        private DbSet<TEntity> _dbSet;
        public MyGenericRepository(MyContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }
        public virtual void insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object id)
        {
            var entity = GetById(id);
            Delete(entity);
        }

        public virtual void Save()
        { 
        _context.SaveChanges();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where=null,Func<IQueryable<TEntity>,
                                                IOrderedQueryable<TEntity>> orderby=null)
        { 
        
        }


    }
}
