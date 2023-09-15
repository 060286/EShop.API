namespace EShop.API.Base
{
    public interface IEditable
    {
        public string? EditedBy { get; set; }

        public DateTime? EditedAt { get; set; }
    }
}
