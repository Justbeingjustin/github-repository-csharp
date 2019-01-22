using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class ReleasesTest
    {
        [Fact]
        public void GetReleases()
        {
            var textCollector = new TextCollector();
            var analyzer = new ReleasesAnalyzer(textCollector.GetBitcoinHTML());
            var releases = analyzer.GetReleases();
            Assert.Equal(213, releases);
        }
    }
}