using System;

public class Leap
{

		public static void InputRead()
	{
		Console.WriteLine("Enter a year");
		int year = Convert.ToInt32(Console.ReadLine());
		LeapYear(year); 
	}
		
		public static void LeapYear(int year)
		{
		int a = year % 4;
		int b = year % 400;
		if (a == 0 && b == 0)
			Console.WriteLine("LEAP year");
		else
			Console.WriteLine("not a LEAP year");
	}
	}

