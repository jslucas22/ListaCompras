using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Items
{
    public class ItemsCartRequest
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; } = Guid.NewGuid().ToString();

        [JsonPropertyName("id_product")]
        public string? IdProduct { get; set; }

        [JsonPropertyName("id_user")]
        public string? IdUser { get; set; }

        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }
    }
}
