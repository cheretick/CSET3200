using System;
using System.IO;

namespace NameAndAddress
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your address: ");
			string address = Console.ReadLine();

			StreamWriter sw = new StreamWriter("G:\\C#\\.NET Projects\\CSET3200\\HW3\\NameAndAddress\\NameAndAddress\\Properties\\NameAndAddress.txt");
			sw.WriteLine($"Student Name: {name}");
			sw.WriteLine($"Student Address: {address}");
			sw.Close();
		}
	}
}
