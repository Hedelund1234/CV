using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Erfaring
    {
        [JsonPropertyName("firma")]
        public string Firma { get; set; } = "";

        [JsonPropertyName("lokation")]
        public string Lokation { get; set; } = "";

        [JsonPropertyName("stilling")]
        public string Stilling { get; set; } = "";

        [JsonPropertyName("periode")]
        public string Periode { get; set; } = "";

        [JsonPropertyName("beskrivelse")]
        public string Beskrivelse { get; set; } = "";
    }
}
