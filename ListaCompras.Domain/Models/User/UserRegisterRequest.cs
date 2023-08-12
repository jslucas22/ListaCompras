using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.User
{
    public class UserRegisterRequest
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }
    }
}
