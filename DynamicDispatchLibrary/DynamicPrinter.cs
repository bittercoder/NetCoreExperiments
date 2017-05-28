using System;

namespace DynamicDispatchLibrary
{
    public class DynamicPrinter
    {
	    public static void Print(object item)
	    {
		    PrintMe((dynamic)item);
	    }

	    static void PrintMe(int i)
	    {
		    Console.WriteLine($"integer: {i}");
	    }

	    static void PrintMe(string s)
		{
		    Console.WriteLine($"string: {s}");
	    }

	    static void PrintMe(object o)
	    {
		    Console.WriteLine($"object: {o ?? "<null>"}");
	    }
	}
}
