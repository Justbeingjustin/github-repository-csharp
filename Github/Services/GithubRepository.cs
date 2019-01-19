using Github.Analyzers;
using Github.Models;

namespace Github.Services
{
    public class GithubRepository : IGithubRepository
    {
        private readonly WatchAnalyzer _watchAnalyzer;
        private readonly StarsAnalyzer _starsAnalyzer;
        private readonly ReleasesAnalyzer _releasesAnalyzer;
        private readonly PullRequestAnalyzer _pullRequestAnalyzer;
        private readonly IssuesAnalyzer _issuesAnalyzer;
        private readonly ForkAnalyzer _forkAnalyzer;
        private readonly ContributorsAnalyzer _contributorsAnalyzer;
        private readonly CommitsAnalyzer _commitsAnalyzer;
        private readonly BranchAnalyzer _branchAnalyzer;

        public GithubRepository(WatchAnalyzer watchAnalyzer, StarsAnalyzer starsAnalyzer,
            ReleasesAnalyzer releasesAnalyzer, PullRequestAnalyzer pullRequestAnalyzer,
            IssuesAnalyzer issuesAnalyzer, ForkAnalyzer forkAnalyzer,
            ContributorsAnalyzer contributorsAnalyzer,
            CommitsAnalyzer commitsAnalyzer, BranchAnalyzer branchAnalyzer)
        {
            _watchAnalyzer = watchAnalyzer;
            _starsAnalyzer = starsAnalyzer;
            _releasesAnalyzer = releasesAnalyzer;
            _pullRequestAnalyzer = pullRequestAnalyzer;
            _issuesAnalyzer = issuesAnalyzer;
            _forkAnalyzer = forkAnalyzer;
            _contributorsAnalyzer = contributorsAnalyzer;
            _commitsAnalyzer = commitsAnalyzer;
            _branchAnalyzer = branchAnalyzer;
        }

        public GithubRepositoryDetails GetRepositoryDetails()
        {
            return new GithubRepositoryDetails()
            {
                Watches = _watchAnalyzer.GetWatchers(),
                Branches = _branchAnalyzer.GetBranches(),
                Commits = _commitsAnalyzer.GetCommits(),
                Contributors = _commitsAnalyzer.GetCommits(),
                Forks = _forkAnalyzer.GetForks(),
                Issues = _issuesAnalyzer.GetIssues(),
                PullRequests = _pullRequestAnalyzer.GetPullRequests(),
                Releases = _releasesAnalyzer.GetReleases(),
                Stars = _starsAnalyzer.GetStars()
            };
        }
    }
}