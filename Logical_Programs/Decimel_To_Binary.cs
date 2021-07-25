using System;

public class Decimel_To_Binary
{
	public static int number;
	public static int n = 0;
	public static int subtract = 0;
	public static int[] arr=new int[20];
	public static void decimel_to_binary()
	{
		Console.WriteLine("Enter a Decimel number :");
		number = Convert.ToInt32(Console.ReadLine());
		while (Math.Pow(2, n) <= number)
        {
			n++;
        }
		int power = n - 1;
		for(int i=power;i>=1;i--)
        {
			arr[i] =(int) Math.Pow(2, i);
			subtract = number - arr[i];
		}
		Console.WriteLine(power);
	}
}
