using EShop.API.Context;
using System.Data;

namespace EShop.API.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EShopDbContext _eShopDbContext;
        private bool _isCompleted = false;

        public UnitOfWork(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public void Completed()
        {
            _isCompleted = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }

            try
            {
                if (_isCompleted)
                {
                    SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Unit of work error", ex);
            }
            finally
            {
                _eShopDbContext.Dispose();
            }
        }

        public int SaveChanges()
        {
            return _eShopDbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _eShopDbContext.SaveChangesAsync();
        }
    }
}
