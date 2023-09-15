namespace EShop.API.Base
{
    public interface IRemovable
    {
        public string? RemovedBy { get; set; }

        public DateTime? RemovedAt { get; set; }
    }
}
