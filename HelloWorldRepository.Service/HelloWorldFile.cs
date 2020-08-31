using HelloWorldRepository.Interface;
using System.IO;

namespace HelloWorld.Types
{
	public class HelloWorldFile : IHelloWorld
	{
		public void ProcessMessage(string message)
		{
			using (StreamWriter file = System.IO.File.AppendText("c:\\temp\\file.txt"))
			{
				file.WriteLine(message);
				file.Flush();
			}
		}
	}
}
