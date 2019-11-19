using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ReadARestApiFromConsole
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseApiUrl = "http://jsonplaceholder.typicode.com";

        static void Main(string[] args)
        {
            GetUserById(1).Wait();
        }

        private static async Task GetUserById(int id){
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", "Acme Browser");
            var getUserTask = client.GetStringAsync($"{baseApiUrl}/users/{id}");
            var output = await getUserTask;
            //Console.WriteLine(output);
            //convert the output to object
            var data = JsonConvert.DeserializeObject<User>(output);
            Console.WriteLine(data.Address.City);
        }
    }
}
