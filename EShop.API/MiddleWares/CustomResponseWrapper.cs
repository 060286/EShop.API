using System.Text;
using EShop.API.Wrapper.Success;
using Newtonsoft.Json;

namespace EShop.API.MiddleWares
{
    public class CustomResponseWrapper
    {
        private readonly RequestDelegate _next;

        public CustomResponseWrapper(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            Stream originBody = context.Response.Body;

            try
            {
                string responseBody = null;
                using (var memStream = new MemoryStream())
                {
                    context.Response.Body = memStream;

                    await _next(context);

                    memStream.Position = 0;
                    responseBody = new StreamReader(memStream).ReadToEnd();
                }

                var data = JsonConvert.DeserializeObject(responseBody);

                var baseJson = new SuccessResponseWrapper(data, statusCode: context.Response.StatusCode, true);

                var bufferRes = JsonConvert.SerializeObject(baseJson);

                var buffer = Encoding.UTF8.GetBytes(bufferRes);
                using (var output = new MemoryStream(buffer))
                {
                    await output.CopyToAsync(originBody);
                }
            }
            finally
            {
                context.Response.Body = originBody;
            }
        }
    }

    public static class UseCustomResponseMiddleWare
    {
        public static IApplicationBuilder UseCustomResponseWrapperMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomResponseWrapper>();
        }
    }
}