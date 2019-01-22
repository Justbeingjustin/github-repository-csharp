using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class IssuesTest
    {
        [Fact]
        public void GetIssues()
        {
            var textCollector = new TextCollector();
            var analyzer = new IssuesAnalyzer(textCollector.GetBitcoinHTML());
            var issues = analyzer.GetIssues();
            Assert.Equal(624, issues);
        }
    }
}