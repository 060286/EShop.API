namespace EShop.API.Base;

public class BaseEntity : ICreatable, IEditable, IRemovable
{
    public string? CreatedBy { get; set; }

    public string? EditedBy { get; set; }

    public string? RemovedBy { get; set; }

    public DateTime? EditedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? RemovedAt { get; set; }
}
