using CV.Interfaces;
using CV.Models.GithubModels;
using System.Net.Http.Json;

namespace CV.Services
{
    public class GithubService : IGithubService
    {
        private readonly HttpClient _httpClient;
        public GithubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<GithubRepo>> GetPublicRepoAsync(string username)
        {
            var url = $"https://api.github.com/users/{username}/repos?per_page=100&sort=updated";
            var repos = await _httpClient.GetFromJsonAsync<List<GithubRepo>>(url);
            return repos ?? new List<GithubRepo>();
        }
    }
}
