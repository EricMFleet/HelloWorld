using NUnit.Framework;
using HelloWorld.Factory;

namespace HelloWorld.Tests
{

	public class Tests
	{
		[Test]
		public void RepositoryFactory_Console_OfTypeHelloWorldConsole()
		{
			//Arrange
			string repositoryType = "console";

			//Act
			var repository = RepositoryFactory.GetRepository(repositoryType);

			//Assert
			Assert.IsInstanceOf(typeof(Types.HelloWorldConsole), repository);
		}


		[Test]
		public void RepositoryFactory_File_OfTypeHelloWorldFile()
		{
			//Arrange
			string repositoryType = "file";

			//Act
			var repository = RepositoryFactory.GetRepository(repositoryType);

			//Assert
			Assert.IsInstanceOf(typeof(Types.HelloWorldFile), repository);
		}
	}
}
