using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class ReleasesAnalyzer
    {
        private readonly string _html;

        public ReleasesAnalyzer(string html)
        {
            _html = html;
        }

        public long GetReleases()
        {
            var remainingText = _html.Substring(_html.IndexOf("svg class=\"octicon octicon-tag\""));
            remainingText = remainingText.Between("svg class=\"octicon octicon-tag\"", "</a>");
            remainingText = remainingText.Between("num text-emphasized\">", "</span");
            return Convert.ToInt64(remainingText.Replace(",", "").Replace("/n", "").Replace(" ", ""));
        }
    }
}