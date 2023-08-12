using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Items
{
    public class ItemsCartResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }
    }
}
