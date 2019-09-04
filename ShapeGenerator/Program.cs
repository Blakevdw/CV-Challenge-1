using System;

namespace ShapeGenerator
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Input your chosen shape, colour and length/area specifications!");


			while (true)
			{
				Console.Clear();
				DisplayAllOptions();
				Console.WriteLine("pick an option:");
				Console.WriteLine(" (1) -> Create Square");
				Console.WriteLine(" (2) -> Create Rectangle");
				Console.WriteLine(" (3) -> Exit Program");



				var key = Console.ReadKey(true);

				if (key.Key == ConsoleKey.D1)
				{
					ReadNewSquare();
				}

				if (key.Key == ConsoleKey.D2)
				{
					ReadNewRectangle();
				}

				else if (key.Key == ConsoleKey.D3)
				{
					break;
				}

				else
				{
					Console.WriteLine("Invalid Input");
					Console.ReadKey(true);
				}
			}
		}
	}
}
