using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Projekt
    {
        [JsonPropertyName("navn")]
        public string Navn { get; set; } = "";

        [JsonPropertyName("beskrivelse")]
        public string Beskrivelse { get; set; } = "";

        [JsonPropertyName("teknologier")]
        public List<string> Teknologier { get; set; } = new();

        [JsonPropertyName("highlights")]
        public List<string> Highlights { get; set; } = new();

        [JsonPropertyName("repository")]
        public string Repository { get; set; } = "";
    }
}
