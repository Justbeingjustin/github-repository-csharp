using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class CommitsAnalyzer
    {
        private readonly string _html;

        public CommitsAnalyzer(string html)
        {
            _html = html;
        }

        public long GetCommits()
        {
            var remainingText = _html.Substring(_html.IndexOf("svg class=\"octicon octicon-history\""));
            remainingText = remainingText.Between("svg class=\"octicon octicon-history\"", "</a>");
            remainingText = remainingText.Between("num text-emphasized\">", "</span");
            return Convert.ToInt64(remainingText.Replace(",", "").Replace("/n", "").Replace(" ", ""));
        }
    }
}