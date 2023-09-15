namespace EShop.API.Base
{
    public interface ICreatable
    {
        public string? CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
