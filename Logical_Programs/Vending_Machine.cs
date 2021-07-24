using System;

public class Vending_Machine
{
	public static int[] arr = { 1000, 500, 100, 50, 10, 5, 2, 1 };
	public static int change = 0;
	public static void vending()
	{
		int i = 0;
		int counter = 0;
		int[] notes = new int[8];
		Console.WriteLine("Enter the Change :");
		change = Convert.ToInt32(Console.ReadLine());
		for (i = 0; i < arr.Length; i++)
		{
			while (change / arr[i] != 0)
			{
				if (arr[i] == 1000 || arr[i] == 100 ||arr[i]==10)
				{
					notes[i] = change / arr[i];
					change = change % arr[i];				
				}
				else
				{					
					notes[i] = ++counter;
					change = change % arr[i];
				}			
			}
			counter = 0;
		}
		for (i = 0; i < notes.Length; i++)
		{
			Console.WriteLine("Number of Rs " + arr[i] + " " + "Notes needed : " + notes[i]);
			counter=counter+notes[i];
		}
		Console.WriteLine("Total number of minumim notes needed for the change is :"+counter);
	}
}

