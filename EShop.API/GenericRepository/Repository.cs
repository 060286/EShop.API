using EFCore.BulkExtensions;
using EShop.API.Context;
using EShop.API.GenericRepository.Interface;

namespace EShop.API.GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly EShopDbContext _eShopDbContext;

        public Repository(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _eShopDbContext.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _eShopDbContext.Set<TEntity>().Remove(entity);
        }

        public TEntity Get(Guid id)
        {
            return _eShopDbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _eShopDbContext.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            _eShopDbContext.Update(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _eShopDbContext.BulkUpdateAsync(new List<TEntity>
            {
                entity
            });
        }

        public async Task DeleteAsync(IList<TEntity> entities)
        {
            await _eShopDbContext.BulkDeleteAsync(entities);
        }

        public async Task CreateAsync(IList<TEntity> entities)
        {
            await _eShopDbContext.BulkInsertAsync(entities);
        }

        public async Task ReadAsync(IList<TEntity> entities)
        {
            await _eShopDbContext.BulkReadAsync(entities);
        }
    }
}
