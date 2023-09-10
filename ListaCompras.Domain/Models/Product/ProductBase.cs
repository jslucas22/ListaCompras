using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.Product
{
    public class ProductBase
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "The field {0} is required.")]
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The field {0} is required.")]
        [JsonPropertyName("supplier")]
        public string Supplier { get; set; } = string.Empty;

        [Required(ErrorMessage = "The field {0} is required.")]
        [JsonPropertyName("fabrication")]
        public DateTime Fabrication { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [JsonPropertyName("expiration")]
        public DateTime Expiration { get; set; }

        [Required(ErrorMessage = "The field {0} is required.")]
        [JsonPropertyName("amount")]
        public short Amount { get; set; }
    }
}
