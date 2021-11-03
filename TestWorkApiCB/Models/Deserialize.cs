namespace TestWorkApiCB.Models
{
    public static class Deserialize
    {
        public static async Task<Daily> deserialize(string Url)
        {
            using (var httpClient = new HttpClient())
            {
                var request = await httpClient.GetFromJsonAsync<Daily>(Url);
                return request;
            }
        }
    }
}
