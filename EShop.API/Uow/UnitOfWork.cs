using EShop.API.Base;
using EShop.API.Context;
using Microsoft.EntityFrameworkCore;
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
            BeforeSaveChanges();

            return _eShopDbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            BeforeSaveChanges();

            return await _eShopDbContext.SaveChangesAsync();
        }

        private void BeforeSaveChanges()
        {
            var entityEntries = _eShopDbContext.ChangeTracker.Entries();

            foreach (var entry in entityEntries)
            {
                if (entry.Entity is ICreatable creatableEntity &&
                    entry.State == EntityState.Added)
                {
                    creatableEntity.CreatedBy = "tamle.dev";
                    creatableEntity.CreatedAt = DateTime.Now;
                }

                if (entry.Entity is IEditable editableEntity &&
                    entry.State == EntityState.Modified)
                {
                    editableEntity.EditedAt = DateTime.Now;
                    editableEntity.EditedBy = "tamle.dev";
                }

                if (entry.Entity is IRemovable removableEntity &&
                    entry.State == EntityState.Deleted)
                {
                    removableEntity.RemovedBy = "tamle.dev";
                    removableEntity.RemovedAt = DateTime.Now;
                }
            }
        }
    }
}
