using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class WatchAnalyzer
    {
        private readonly string _html;

        public WatchAnalyzer(string html)
        {
            _html = html;
        }

        public long GetWatchers()
        {
            var remainingText = _html.Substring(_html.IndexOf("a class=\"social-count\" href=\""));
            remainingText = remainingText.Between("a class=\"social-count\" href=\"", "</a>");
            remainingText = remainingText.Between("aria-label=\"", " users are watching");
            return Convert.ToInt64(remainingText);
        }
    }
}