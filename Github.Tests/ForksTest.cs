using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class ForksTest
    {
        [Fact]
        public void GetForks()
        {
            var textCollector = new TextCollector();
            var analyzer = new ForksAnalyzer(textCollector.GetBitcoinHTML());
            var forks = analyzer.GetForks();
            Assert.Equal(21934, forks);
        }
    }
}