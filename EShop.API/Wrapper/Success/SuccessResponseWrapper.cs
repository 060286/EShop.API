using Newtonsoft.Json;

namespace EShop.API.Wrapper.Success
{
    public class SuccessResponseWrapper
    {
        public SuccessResponseWrapper(object data, int statusCode, bool isSuccess)
        {
            Data = data;
            StatusCode = statusCode;
            IsSuccess = isSuccess;
        }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}