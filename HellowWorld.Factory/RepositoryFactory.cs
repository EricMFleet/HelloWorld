using HelloWorld.Types;
using HelloWorldRepository.Interface;
using System;

namespace HelloWorld.Factory
{
	public static class RepositoryFactory
	{
		public static IHelloWorld GetRepository(string repositoryType)
		{
			IHelloWorld repository = null;

			switch (repositoryType.ToLower())
			{
				case "console":
					repository = new HelloWorldConsole();
					break;
				case "file":
					repository = new HelloWorldFile();
					break;
				default:
					throw new ArgumentException("This is not a supported type");
			}

			return repository;
		}
	}
}
