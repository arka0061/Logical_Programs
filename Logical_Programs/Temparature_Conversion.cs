using System;

namespace Logical_Programs
{
	public class Temparature_Conversion
	{
		public static double temparature;
		public static double celsius;

		public static void temp()
		{
			Console.WriteLine("Enter 1 for Celsius to Fahrenheit and 2 for Fareheit to Celsius");
			int check = Convert.ToInt32(Console.ReadLine());
		    switch(check)
            {
				case 1:
					Console.WriteLine("Enter Temparature : ");
					temparature = Convert.ToDouble(Console.ReadLine());
					temparature = (temparature * 9) / 5 + 32;
					Console.WriteLine("Celsius to Fahrenheit : "+ temparature);
					break;
				case 2:

					Console.WriteLine("Enter Temparature : ");
					temparature = Convert.ToDouble(Console.ReadLine());
					temparature = (temparature - 32)* 5/9;
					Console.WriteLine(" Fahrenheit to  Celsius  : " + temparature);
					break;
				default:
					Console.WriteLine("Wrong Input!");
					break;
			}
		}
	}
}
