using System;
public class Coupon_Number
{
	public static void coupon_Number()
	{
		int coupons;
		int count = 0;
		int i;
		Random random = new Random();
		Console.WriteLine("Enter the number of coupons");
		coupons = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[coupons+1];
		for (i = 0; i < coupons + 1; i++)
		{ arr[i] = random.Next(100); }
		
		for (i = 0;i< coupons;i++)
		{
			Console.WriteLine(arr[i]);
			if (arr[i] == arr[i+1])
			{
				count--;
			}
			else
			{
				
				count++;
			}
			

		}
		Console.WriteLine("The number of Unique Distinct coupons is : " + count);
	}
}
