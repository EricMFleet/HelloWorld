using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using HelloWorld.Factory;

namespace HelloWorld.ConsoleApp
{
	class Program 
	{
		static public void Main(string[] args)
		{
			string repositoryType = GetRepositoryType();
			var myRepository = RepositoryFactory.GetRepository(repositoryType);

			string message = RetrieveMessage().Result;

			try
			{
				myRepository.ProcessMessage(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

		private static string GetRepositoryType()
		{
			//return "file";
			return ConfigurationManager.AppSettings.Get("repositoryType");
		}

		static async Task<string> RetrieveMessage()
		{
			using (HttpClient client = new HttpClient())
			{
				//TODO: Move url to a config.
				client.BaseAddress = new Uri("https://localhost:44399/api/Message");
				var response = await client.GetAsync("https://localhost:44399/api/Message");
				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}