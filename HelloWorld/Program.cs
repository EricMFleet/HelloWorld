using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			HandleMessage("");
		}



		static async Task<string> GetMessage()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("http://localhost:44399/api/Message");

			try
			{
				var response = await client.GetAsync("http://localhost:44399/api/Message");
				string x = await response.Content.ReadAsStringAsync();
				return x;
			}
			catch (Exception ex)
			{
				return "";
			}
		}

		private static void HandleMessage(string message)
		{
			Console.WriteLine("Hello World");
		}
	}
}
