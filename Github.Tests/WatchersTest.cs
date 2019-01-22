using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class WatchersTest
    {
        [Fact]
        public void GetWatchers()
        {
            var textCollector = new TextCollector();
            var watchAnalyzer = new WatchesAnalyzer(textCollector.GetBitcoinHTML());
            var watchers = watchAnalyzer.GetWatchers();
            Assert.Equal(3524, watchers);
        }
    }
}