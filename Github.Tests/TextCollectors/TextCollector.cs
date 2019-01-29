using System.IO;
using System.Reflection;

namespace Github.Tests.TextCollectors
{
    public class TextCollector
    {
        public string GetBitcoinHTML()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Github.Tests.Files.bitcoin.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public string GetRippleOneIssueHTML()
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Github.Tests.Files.ripple-one-issue.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}