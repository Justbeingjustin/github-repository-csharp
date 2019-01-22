using Github.Analyzers;
using Github.Models;

namespace Github.Services
{
    public class GithubRepository : IGithubRepository
    {
        private readonly WatchesAnalyzer _watchAnalyzer;
        private readonly StarsAnalyzer _starsAnalyzer;
        private readonly ReleasesAnalyzer _releasesAnalyzer;
        private readonly PullRequestsAnalyzer _pullRequestAnalyzer;
        private readonly IssuesAnalyzer _issuesAnalyzer;
        private readonly ForksAnalyzer _forkAnalyzer;
        private readonly ContributorsAnalyzer _contributorsAnalyzer;
        private readonly CommitsAnalyzer _commitsAnalyzer;
        private readonly BranchesAnalyzer _branchAnalyzer;

        public GithubRepository(WatchesAnalyzer watchAnalyzer, StarsAnalyzer starsAnalyzer,
            ReleasesAnalyzer releasesAnalyzer, PullRequestsAnalyzer pullRequestAnalyzer,
            IssuesAnalyzer issuesAnalyzer, ForksAnalyzer forkAnalyzer,
            ContributorsAnalyzer contributorsAnalyzer,
            CommitsAnalyzer commitsAnalyzer, BranchesAnalyzer branchAnalyzer)
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