using System.Text.Json.Serialization;

namespace ListaCompras.Domain.Models.User
{
    public class UserRegisterRequest : UserBase
    {
        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; set; }

        public UserRegisterRequest()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
