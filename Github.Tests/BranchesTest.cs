using Github.Analyzers;
using Github.Tests.TextCollectors;
using Xunit;

namespace Github.Tests
{
    public class BranchesTest
    {
        [Fact]
        public void GetBranches()
        {
            var textCollector = new TextCollector();
            var analyzer = new BranchesAnalyzer(textCollector.GetBitcoinHTML());
            var branches = analyzer.GetBranches();
            Assert.Equal(5, branches);
        }
    }
}