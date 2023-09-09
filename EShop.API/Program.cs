
using EShop.API.DI;
using FastEndpoints;

namespace EShop.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Add services to the container.
            var builder = WebApplication.CreateBuilder(args);

            var configuration = builder.Configuration;
            builder.Services.AddRegisterProductServiceDI();
            builder.Services.AddCustomFastEndpoint();
            builder.Services.AddAuthorization();
            builder.Services.AddCustomSQLServerConnection(configuration);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCustomSwagger();
            #endregion

            #region Configure the HTTP request pipeline.
            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseFastEndpoints();
            #endregion

            app.Run();
        }
    }
}