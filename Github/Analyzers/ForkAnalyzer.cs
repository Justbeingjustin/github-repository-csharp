using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class ForkAnalyzer
    {
        private readonly string _html;

        public ForkAnalyzer(string html)
        {
            _html = html;
        }

        public long GetForks()
        {
            var remainingText = _html.Substring(_html.IndexOf("members\" class=\"social-count\""));
            remainingText = remainingText.Between("members\" class=\"social-count\"", "</a>");
            remainingText = remainingText.Between("aria-label=\"", " users forked this");
            return Convert.ToInt64(remainingText);
        }
    }
}