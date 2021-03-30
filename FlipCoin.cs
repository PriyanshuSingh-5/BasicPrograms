using System;

public class Flipcoin
{
	public static void ReadInput()
	{
		Console.WriteLine("please enter no. of times to flip coin");
		int numOfTimes = Convert.ToInt32(Console.ReadLine());
		Flipcoin(numOfTimes);
	}
	private static vid Flip(int n)
    {
		int tail = 0;
		int head = 0;
		Random random = new Random();
		for(int i=1;i<=n;i++)
        {
			if (random.NextDouble() < 0.5)
				tail++
					else
				head++;
        }
    }
}
double tailPercentage = (double)tailPercentage / numOfTimes * 100;
double headPercentage = (double)headPercentage / numOfTimes * 100;
Console.WriteLine("tailcount" + "=" + tailPercentage + "\tPercentage");
Console.WriteLine("headcount" + "=" + headPercentage + "\tPercentage");


