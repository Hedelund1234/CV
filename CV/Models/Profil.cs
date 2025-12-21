using System.Text.Json.Serialization;

namespace CV.Models
{
    public class Profil
    {
        [JsonPropertyName("navn")]
        public string Navn { get; set; } = "";

        [JsonPropertyName("kontakt")]
        public Kontakt Kontakt { get; set; } = new();

        [JsonPropertyName("profilTekst")]
        public string ProfilTekst { get; set; } = "";

        [JsonPropertyName("erfaring")]
        public List<Erfaring> Erfaringer { get; set; } = new();

        [JsonPropertyName("uddannelse")]
        public List<Uddannelse> Uddannelser { get; set; } = new();

        [JsonPropertyName("projekter")]
        public List<Projekt> Projekter { get; set; } = new();

        [JsonPropertyName("kompetencer")]
        public List<string> Kompetencer { get; set; } = new();

        [JsonPropertyName("tekniskeFærdigheder")]
        public List<string> TekniskeFærdigheder { get; set; } = new();

        [JsonPropertyName("udmaerkelser")]
        public List<string> Udmærkelser { get; set; } = new();

        [JsonPropertyName("sprog")]
        public List<Sprog> Sprog { get; set; } = new();
    }
}
