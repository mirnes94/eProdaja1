using Microsoft.OpenApi.Models;

namespace eProdaja.WebAPI
{
    internal class BasicAuthScheme : OpenApiSecurityScheme
    {
        public string Type { get; set; }
    }
}