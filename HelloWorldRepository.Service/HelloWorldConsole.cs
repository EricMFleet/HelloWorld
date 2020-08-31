using HelloWorldRepository.Interface;

namespace HelloWorld.Types
{
	public class HelloWorldConsole : IHelloWorld
	{
		public void ProcessMessage(string message)
		{
			System.Console.WriteLine(message);
			System.Console.Read();
		}
	}
}
