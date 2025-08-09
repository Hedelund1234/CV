using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Kontakt
    {
        [JsonPropertyName("adresse")]
        public string Adresse { get; set; } = "";

        [JsonPropertyName("telefon")]
        public string Telefon { get; set; } = "";

        [JsonPropertyName("email")]
        public string Email { get; set; } = "";
    }
}
