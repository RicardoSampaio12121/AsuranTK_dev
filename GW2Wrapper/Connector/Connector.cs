using System.Net.Http;

namespace GW2Wrapper.Connector
{
    /// <summary>
    /// Class of the api connector
    /// </summary>
    class Connector : IConnector
    {
        private readonly string _apiKey;
        private readonly HttpClient _client;
        private const string DefaultUrl = @"https://api.guildwars2.com/";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiKey"></param>
        public Connector(string apiKey, HttpClient client)
        {
            _apiKey = apiKey;
            _client = client;
        }

        public string Call(string endpoint)
        {
            string requestUrl = $@"{DefaultUrl}{endpoint}";
            var stringTask = _client.GetAsync(requestUrl);
            stringTask.Wait();
            var output = stringTask.Result;
            return output.Content.ReadAsStringAsync().Result;
        }
    }
}
