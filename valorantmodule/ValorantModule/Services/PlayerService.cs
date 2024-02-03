using ValorantModule.Models;
using Newtonsoft.Json;

namespace ValorantModule.Services
{
    public class PlayerService
    {
        private HttpClient client;
        public PlayerService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Globals.baseURL);
        }

        public async Task<BasicInformation> GetBaseInformation()
        {
            string callURL = String.Format("val/content/v1/contents?locale=en-US&api_key={0}", Globals.APIKey);
            var response = client.GetAsync(callURL).Result;

            BasicInformation info = new BasicInformation();
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                info = JsonConvert.DeserializeObject<BasicInformation>(content);
            }

            return info;
        }

        public async Task<BasicInformation> GetMatchListByPlayerId(string puuid)
        {
            string callURL = String.Format("val/content/v1/contents?locale=en-US&api_key={0}", Globals.APIKey);
            var response = client.GetAsync(callURL).Result;

            BasicInformation info = new BasicInformation();
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                info = JsonConvert.DeserializeObject<BasicInformation>(content);
            }

            return info;
        }

    }
}
