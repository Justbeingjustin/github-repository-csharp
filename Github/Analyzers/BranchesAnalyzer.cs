using Github.Extensions;
using System;

namespace Github.Analyzers
{
    public class BranchesAnalyzer
    {
        private readonly string _html;

        public BranchesAnalyzer(string html)
        {
            _html = html;
        }

        public long GetBranches()
        {
            var remainingText = _html.Substring(_html.IndexOf("svg class=\"octicon octicon-git-branch\""));
            remainingText = remainingText.Between("svg class=\"octicon octicon-git-branch\"", "</a>");
            remainingText = remainingText.Between("num text-emphasized\">", "</span");
            return Convert.ToInt64(remainingText.Replace(",", "").Replace("/n", "").Replace(" ", ""));
        }
    }
}