using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Items
{
    public class ItemsProductResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonPropertyName("amount")]
        public short Amount { get; set; }

        [JsonPropertyName("product_name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("fabrication_date")]
        public DateTime? FabricationDate { get; set; }

        [JsonPropertyName("expiration_date")]
        public DateTime? ExpirationDate { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }
    }
}
