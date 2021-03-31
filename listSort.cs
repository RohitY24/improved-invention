using System;
using System.Collections.Generic;

class sorter : IComparer<string>
{
	public int Compare(string x, string y)
	{
		
		if (x == null || y == null)
		{
			return 0;
		}
		
		return x.CompareTo(y);
		
	}
}

public class sortmain
{
	
	public static void Main()
	{
		List<string> list1 = new List<string>();
		
		// list elements
		list1.Add("A");
		list1.Add("I");
		list1.Add("G");
		list1.Add("B");
		list1.Add("E");
		list1.Add("H");
		list1.Add("F");
		list1.Add("C");
		list1.Add("J");

		Console.WriteLine("Original List");
		
		Display(list1);
	
		sorter gg = new sorter();
	
		Console.WriteLine("\nSort with a comparer:");

		list1.Sort(gg);
		
		Display(list1);
		
		Console.WriteLine("\nBinarySearch and Insert D");

		int index = list1.BinarySearch("D");

		if (index < 0)
		{
			
			list1.Insert(~index, "D");
			
		}

		Display(list1);
		
	}
	

	public static void Display(List<string> list)
	{
		foreach( string g in list )
		{
			Console.WriteLine(g);
		}
	}
}
