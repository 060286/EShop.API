namespace EShop.API.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        void Completed();

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
