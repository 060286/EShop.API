namespace EShop.API.Wrapper.Error;

public class ErrorResponseWrapper
{
    public required string Message { get; set; }

    public int StatusCode { get; set; }
}