using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Uddannelse
    {
        [JsonPropertyName("institution")]
        public string Instituion { get; set; } = "";

        [JsonPropertyName("lokation")]
        public string Lokation { get; set; } = "";

        [JsonPropertyName("uddannelse")]
        public string UddannelsesNavn { get; set; } = "";

        [JsonPropertyName("periode")]
        public string Periode { get; set; } = "";
    }
}
