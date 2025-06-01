using InvenotryProj.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryProj.Infrastructure.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected InventoryDataContext context;
        public GenericRepository(InventoryDataContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var result = await this.context.Set<T>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            return Activator.CreateInstance<T>();
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
