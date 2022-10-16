using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool continueRun = true;
			int menu;
			int number;

			while(continueRun)
			{
				Console.WriteLine("1. Prime Number\n" +
								  "2. Sum of Digits\n" +
								  "3. Reverse a String\n" +
								  "4. Print HTML tag\n"+
								  "5. Sort Numbers\n\n" +
								  "6. Exit\n");

				Int32.TryParse(Console.ReadLine(), out menu);

				switch (menu)
				{
					case 1:
						ServiceReference1.Service1Client client1	= new ServiceReference1.Service1Client();	

						Console.WriteLine("Enter a number to check if it is a prime number: ");

						try
						{
							number = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine(client1.checkPrime(number)+"\n");
						}
						catch (Exception)
						{
							Console.WriteLine("Invalid Input\n");
						}

						break;
					case 2:
						ServiceReference2.Service2Client client2 = new ServiceReference2.Service2Client();

						Console.WriteLine("Enter number to sum all it's digits: ");
						try
						{
							number = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine(client2.sumDigits(number)+"\n");
						}
						catch (Exception)
						{
							Console.WriteLine("Invalid Input\n");
						}
						break;
					case 3:
						string text;

						ServiceReference3.Service3Client client3 = new ServiceReference3.Service3Client();

						Console.WriteLine("Enter string to reverse: ");

						text = Console.ReadLine();
						Console.WriteLine(client3.reverseString(text)+"\n");
						break;
					case 4:
						string tag;
						string data;

						ServiceReference4.Service4Client client4 = new ServiceReference4.Service4Client();

						Console.WriteLine("Enter Tag: ");
						tag = Console.ReadLine();
						Console.WriteLine("Enter Data: ");
						data = Console.ReadLine();

						Console.WriteLine(client4.htmlOutput(tag,data) + "\n");
						break;
					case 5:
						string sortType;
						string numbers;

						ServiceReference5.Service5Client client5 = new ServiceReference5.Service5Client();

						Console.WriteLine("Enter sort type (Ascending/Descending): ");
						sortType = Console.ReadLine();
						Console.WriteLine("Enter data (e.g. 1,3,4,5): ");
						numbers = Console.ReadLine();

						Console.WriteLine(client5.sortNumbers(sortType, numbers)+ "\n");
						break;
					case 6:
						continueRun = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
