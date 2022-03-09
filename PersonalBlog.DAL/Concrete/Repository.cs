using Microsoft.EntityFrameworkCore;
using PersonalBlog.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.DAL.Concrete
{
    public class Repository<T, TContext> : IRepository<T> where T : class where TContext : DbContext, new()
    {
        public DbSet<T> db { get; set; }
        public TContext context { get; set; }
        public Repository()
        {
            this.context = new TContext();
            db = context.Set<T>();
        }
        public async Task<bool> CreateAsync(T entity)
        {
            await db.AddAsync(entity);
            return await SaveChangeAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await db.AsNoTracking().Where(filter).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await db.AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await db.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            db.Update(entity);
            return await SaveChangeAsync();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await context.SaveChangesAsync() >= 1 ? true : false;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await db.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetAsync()
        {
            return await db.AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
