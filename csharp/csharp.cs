using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Task t = new Task(DownloadPageAsync);
        t.Start();
        Console.ReadLine();
    }

    static async void DownloadPageAsync()
    {
        string page = "https://ip.decodo.com/ip";

        var proxy = new WebProxy("gate.decodo.com:7000")
        {
            UseDefaultCredentials = false,

            Credentials = new NetworkCredential(
                username: "username",
                password: "password")
        };

        var httpClientHandler = new HttpClientHandler()
        {
            Proxy = proxy,
        };

        var client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
        var response = await client.GetAsync(page);
        using (HttpContent content = response.Content)
        {
            string result = await content.ReadAsStringAsync();
            Console.WriteLine(result);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
