﻿using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class WatchesAnalyzer
    {
        private readonly string _html;

        public WatchesAnalyzer(string html)
        {
            _html = html;
        }

        public long GetWatchers()
        {
            var remainingText = _html.Substring(_html.IndexOf("a class=\"social-count\" href=\""));
            remainingText = remainingText.Between("a class=\"social-count\" href=\"", "</a>");
            remainingText = remainingText.Between("aria-label=\"", " user");
            return Convert.ToInt64(remainingText);
        }
    }
}