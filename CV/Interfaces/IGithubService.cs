using CV.Models.GithubModels;

namespace CV.Interfaces
{
    public interface IGithubService
    {
        Task<List<GithubRepo>> GetPublicRepoAsync(string username);
    }
}
