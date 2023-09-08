using FastEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Dto
{
    public class GetProductDetailRequestDto
    {
        public Guid Id { get; set; }

        public string Temp { get; set; }
    }
}
