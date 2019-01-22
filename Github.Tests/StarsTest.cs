using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class StarsTest
    {
        [Fact]
        public void GetStars()
        {
            var textCollector = new TextCollector();
            var analyzer = new StarsAnalyzer(textCollector.GetBitcoinHTML());
            var stars = analyzer.GetStars();
            Assert.Equal(36852, stars);
        }
    }
}