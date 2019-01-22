using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class ContributorsTest
    {
        [Fact]
        public void GetContributors()
        {
            var textCollector = new TextCollector();
            var analyzer = new ContributorsAnalyzer(textCollector.GetBitcoinHTML());
            var contributors = analyzer.GetContributors();
            Assert.Equal(604, contributors);
        }
    }
}