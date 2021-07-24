using System;

public class Day_Of_Week
{
	public static void day_Of_Week()
	{
		int d=0;
		String day_is = "";
		String month="";
		int m=0;
		int y=0;	
		Console.WriteLine("Enter day :");
		d = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter Month :");
		month = Console.ReadLine().ToUpper();
		Console.WriteLine("Enter year :");
		y = Convert.ToInt32(Console.ReadLine());
		switch(month)
        {
			case "JANUARY":
					m = 1;
					break;

			case "February":
				m = 2;
				break;

			case "MARCH":
				m = 3;
				break;

			case "APRIL":
				m = 4;
				break;

			case "MAY":
				m = 5;
				break;

			case "JUNE":
				m = 6;
				break;

			case "JULY":
				m = 7;
				break;

			case "AUGUST":
				m = 8;
				break;

			case "SEPTEMBER":
				m = 9;
				break;

			case "OCTOBER":
				m = 10;
				break;

			case "NOVEMBER":
				m = 11;
				break;

			case "DECEMBER":
				m = 12;
				break;

			default:
				Console.WriteLine("Wrong input!");
				break;

		}
		int y0= (y-(14-m))/12;
		int x = y0 + y0/4- y0/100 + y0 / 400;
		int m0 = (m + 12)* (((14 - m) / 12) - 2);
		int d0 = (d + x + ((31 * m0) / 12)) % 7;
		switch(d0)
        {
			case 0:
				day_is = "Saturday";
				break;
			case 1:
				day_is = "Sunday";
				break;
			case 2:
				day_is = "Monday";
				break;
			case 3:
				day_is = "Tuesday";
				break;
			case 4:
				day_is = "Wednesday";
				break;
			case 5:
				day_is = "Thursday";
				break;
			case 6:
				day_is = "Friday";
				break;

		}
		Console.WriteLine("The day is: "+ day_is);




	}
}
