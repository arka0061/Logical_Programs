using System;

public class Reverse
{
	public static void reverse()
	{
        int number, reverse = 0, split;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        while (number != 0)
        {
            split = number % 10;
            reverse = reverse * 10 + split;
            number /= 10;
        }
        Console.Write("Reversed Number: " + reverse);
    }
}
