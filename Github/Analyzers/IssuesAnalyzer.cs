using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class IssuesAnalyzer
    {
        private readonly string _html;

        public IssuesAnalyzer(string html)
        {
            _html = html;
        }

        public long GetIssues()
        {
            var remainingText = _html.Substring(_html.IndexOf("<span class=\"Counter\">"));
            remainingText = remainingText.Between("<span class=\"Counter\">", "</span>");
            return Convert.ToInt64(remainingText);
        }
    }
}