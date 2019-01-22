﻿using Github.Analyzers;
using Github.Models;
using Github.Services;

namespace Github
{
    public class GithubRepositoryCoordinator
    {
        private readonly string _url;

        public GithubRepositoryCoordinator(string url)
        {
            _url = url;
        }

        public GithubRepositoryDetails GetRepositoryDetails()
        {
            var HTMLCollector = new HTMLCollector(_url); // we could pass this in through the constructor, but this simplifies the client code.

            var html = HTMLCollector.Collect();

            var githubRepository = new GithubRepository(
               new WatchesAnalyzer(html),
               new StarsAnalyzer(html),
               new ReleasesAnalyzer(html),
               new PullRequestsAnalyzer(html),
               new IssuesAnalyzer(html),
               new ForksAnalyzer(html),
               new ContributorsAnalyzer(html),
               new CommitsAnalyzer(html),
               new BranchesAnalyzer(html));

            return githubRepository.GetRepositoryDetails();
        }
    }
}