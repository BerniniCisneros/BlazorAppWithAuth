using RestSharp;
using Method = RestSharp.Method;

namespace Territorios.Data
{
    public class MobileService
    {
        private readonly string token = "gw0lz5kajyczjagb";         //instance Token
        private readonly string url = "https://api.ultramsg.com/" + "instance75647" + "/messages/chat";
        public MobileService() { }
        public async Task SendMessageAsync(string message, string to)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("token", token);
                request.AddParameter("to", to);
                request.AddParameter("body", message);

                await client.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
