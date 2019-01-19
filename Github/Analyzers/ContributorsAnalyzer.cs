using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class ContributorsAnalyzer
    {
        private readonly string _html;

        public ContributorsAnalyzer(string html)
        {
            _html = html;
        }

        public long GetContributors()
        {
            var remainingText = _html.Substring(_html.IndexOf("svg class=\"octicon octicon-organization\""));
            remainingText = remainingText.Between("svg class=\"octicon octicon-organization\"", "</a>");
            remainingText = remainingText.Between("num text-emphasized\">", "</span");
            return Convert.ToInt64(remainingText.Replace(",", "").Replace("/n", "").Replace(" ", ""));
        }
    }
}