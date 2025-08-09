using System.IO;
using System.Text.Json;
using CV.Interfaces;
using CV.Models;
using Microsoft.Extensions.Options;

namespace CV.Services
{
    public class ImportDataFromJsonService : IImportDataFromJsonService
    {
        private readonly HttpClient _httpClient;
        private static readonly JsonSerializerOptions Options = new()
        {
            PropertyNameCaseInsensitive = true,
            ReadCommentHandling = JsonCommentHandling.Skip
        };

        public ImportDataFromJsonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Profil?> GetCVAsync()
        {
            var response = await _httpClient.GetAsync("data/cv.json");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var profil = JsonSerializer.Deserialize<Profil>(json, Options);

            return profil;
        }

    }
}
