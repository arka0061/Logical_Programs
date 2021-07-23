using System;

public class Coupon_Number
{
	public static void coupon_Number()
	{
		int number_of_coupons;
		int i;
		int j = 0; ;
		int randomizer = 0;
		int count = 0;
		int z = 1;
		Random random = new Random();
		Console.WriteLine("Enter the no. of Distinct Coupon number of 2 digits");
		number_of_coupons = Convert.ToInt32(Console.ReadLine());
		int []coupon_array=new int[number_of_coupons];
		for( i=0; i<number_of_coupons;i++)
        {
			Console.WriteLine("Enter a single digit coupon no: "+z);
			z++;
			coupon_array[i] = Convert.ToInt32(Console.ReadLine());

		}
		for(i=0;i<number_of_coupons;i++)
        {
			while(coupon_array[i]!=randomizer)
            {
				randomizer = random.Next(1, 100);
				count++;
            }

        }
		Console.WriteLine("The number of random values required to get the coupon number is : " + count);
	}
}
