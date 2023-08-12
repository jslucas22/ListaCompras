using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Authentication
{
    public class UserLoginRequest
    {
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }
    }
}
