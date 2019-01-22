using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class CommitsTest
    {
        [Fact]
        public void GetCommits()
        {
            var textCollector = new TextCollector();
            var analyzer = new CommitsAnalyzer(textCollector.GetBitcoinHTML());
            var commits = analyzer.GetCommits();
            Assert.Equal(19343, commits);
        }
    }
}