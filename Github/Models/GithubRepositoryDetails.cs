namespace Github.Models
{
    public class GithubRepositoryDetails
    {
        public long Watches { get; set; }
        public long Stars { get; set; }
        public long Forks { get; set; }
        public long Issues { get; set; }
        public long PullRequests { get; set; }
        public long Commits { get; set; }
        public long Branches { get; set; }
        public long Releases { get; set; }
        public long Contributors { get; set; }
    }
}