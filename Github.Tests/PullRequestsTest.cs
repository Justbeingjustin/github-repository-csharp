using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class PullRequestsTest
    {
        [Fact]
        public void GetPullRequests()
        {
            var textCollector = new TextCollector();
            var analyzer = new PullRequestsAnalyzer(textCollector.GetBitcoinHTML());
            var pullRequests = analyzer.GetPullRequests();
            Assert.Equal(250, pullRequests);
        }
    }
}