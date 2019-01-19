using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class StarsAnalyzer
    {
        private readonly string _html;

        public StarsAnalyzer(string html)
        {
            _html = html;
        }

        public long GetStars()
        {
            var remainingText = _html.Substring(_html.IndexOf("a class=\"social-count js-social-count\" href=\""));
            remainingText = remainingText.Between("a class=\"social-count js-social-count\" href=\"", "</a>");
            remainingText = remainingText.Between("aria-label=\"", " users starred this");
            return Convert.ToInt64(remainingText);
        }
    }
}