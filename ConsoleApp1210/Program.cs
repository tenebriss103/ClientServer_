using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string message = "Hello, Server";
            


            var answear = GetRequest("http://localhost:51803/Home/", message).Result;



            Console.WriteLine(answear.ToString());
            Console.ReadLine();


        }
        static async Task<string> GetRequest (string adress, string message)
        {
            HttpClient client = new HttpClient();
            
            
                Uri uri = new Uri(adress);
                StringContent content = new StringContent(message);


            var request = await client.PostAsync(adress, content);
            var responce = await request.Content.ReadAsStringAsync();
            return responce;

        }
    }
}
