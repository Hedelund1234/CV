using System.Globalization;
using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Sprog
    {
        [JsonPropertyName("sprog")]
        public string SprogNavn { get; set; } = "";

        [JsonPropertyName("niveau")]
        public string Niveau { get; set; } = "";
    }
}
