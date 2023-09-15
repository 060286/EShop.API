namespace EShop.API.Base;

public interface IKey<TType>
{
    TType Id { get; set; }
}
