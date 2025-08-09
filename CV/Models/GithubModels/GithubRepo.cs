namespace CV.Models.GithubModels
{
    public class GithubRepo
    {
        public string name { get; set; } = "";
        public string html_url { get; set; } = "";
        public string? description { get; set; }
        public string? homepage { get; set; }
    }
}
