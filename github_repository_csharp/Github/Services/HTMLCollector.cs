using System;
using System.IO;
using System.Net;
using System.Text;

namespace Github.Services
{
    public class HTMLCollector
    {
        private readonly string _githubUrl;

        public HTMLCollector(string githubUrl)
        {
            _githubUrl = githubUrl;
        }

        public string Collect()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_githubUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception("Invalid status code of " + response.StatusCode);
            }

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;

            if (response.CharacterSet == null)
            {
                readStream = new StreamReader(receiveStream);
            }
            else
            {
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            }

            string data = readStream.ReadToEnd();

            response.Close();
            readStream.Close();
            return data;
        }
    }
}