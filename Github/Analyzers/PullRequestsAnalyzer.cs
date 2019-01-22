using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class PullRequestsAnalyzer
    {
        private readonly string _html;

        public PullRequestsAnalyzer(string html)
        {
            _html = html;
        }

        public long GetPullRequests()
        {
            var remainingText = _html.Substring(_html.IndexOf("Pull requests</span>"));
            remainingText = remainingText.Between("Pull requests</span>", "</a>");
            remainingText = remainingText.Between("<span class=\"Counter\">", "</span>");
            return Convert.ToInt64(remainingText);
        }
    }
}