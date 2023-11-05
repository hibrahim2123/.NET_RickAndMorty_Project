using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication4.Core.Application.Interfaces;
using WebApplication4.Persistance.Context;

namespace WebApplication4.Persistance.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly RickyAndMartyContext rickyAndMartyContext;
        public Repository(RickyAndMartyContext context)
        {
            this.rickyAndMartyContext = context;
        }
        public async Task CreateAsync(T entity)
        {
            await this.rickyAndMartyContext.Set<T>().AddAsync(entity);
            await this.rickyAndMartyContext.SaveChangesAsync();
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await this.rickyAndMartyContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.rickyAndMartyContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await this.rickyAndMartyContext.Set<T>().FindAsync(id);
        }


    }


}
