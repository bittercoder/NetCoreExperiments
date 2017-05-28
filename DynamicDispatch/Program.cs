using System;
using DynamicDispatchLibrary;

namespace DynamicDispatch
{
	public class Program
	{
		public static void Main(string[] args)
		{
			DynamicPrinter.Print(1);
			DynamicPrinter.Print("test");
			DynamicPrinter.Print(new { page = 1, pageSize = 20});
			Console.ReadLine();
		}
	}
}
