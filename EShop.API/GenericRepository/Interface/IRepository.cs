namespace EShop.API.GenericRepository.Interface
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();

        TEntity Get(Guid id);

        void Update(TEntity entity);

        Task CreateAsync(TEntity entity);

        void Delete(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(IList<TEntity> entities);

        Task CreateAsync(IList<TEntity> entities);

        Task ReadAsync(IList<TEntity> entities);
    }
}
