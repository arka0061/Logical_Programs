using System;

public class Monthly_Payment
{
	public static double P, Y, R, payment;
	public static void monthly_payment()
	{
		Console.WriteLine("Enter principle amount");
		P = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Year");
		Y= Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Rate of interest" );
		R= Convert.ToInt32(Console.ReadLine());
		double n = 12 * Y;
		double r = R / (12 * 100);
		payment=(P*r)/1-(Math.Pow(1+r,-n));
		Console.WriteLine("Payment is : " + payment);
	}
}
