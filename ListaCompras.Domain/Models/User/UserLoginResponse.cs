using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Authentication
{
    public class UserLoginResponse
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("creation")]
        public DateTime Creation { get; set; }
    }
}
