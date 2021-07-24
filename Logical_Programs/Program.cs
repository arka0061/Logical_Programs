using System;

namespace Logical_Programs
{
    class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press 1 to 10 to run the Following programs and press 11 to exit!");
            Console.WriteLine("Press 1 for Fibonacci!");
            Console.WriteLine("Press 2 for Perfect Number!");
            Console.WriteLine("Press 3 for Prime or not!");
            Console.WriteLine("Press 4 for Reversing a Number");
            Console.WriteLine("Press 5 for Coupon Numbers!");
            Console.WriteLine("Press 6 for Stop_Watch!");
            Console.WriteLine("Press 7 for Temparature Conversion!");
            Console.WriteLine("Press 8 for Day Of Week!");
            Console.WriteLine("Press 9 for Vending Machine!");
            Console.WriteLine("Press 10 for Monthly_Payemnt!");


            Console.WriteLine("----------------------------------------------------------------------------------------");         
            while (choice != 11)
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Fibonacci");
                        Fibonacci fib = new Fibonacci();
                        Fibonacci.Fibo();
                        break;
                    case 2:

                        Console.WriteLine("Perfect Number!");
                        Perfect yr = new Perfect();
                        Perfect.perfect();
                        break;
                    case 3:
                        Console.WriteLine("Prime Check!");
                        Prime p = new Prime();
                        Prime.prime();
                        break;

                    case 4:
                        Console.WriteLine("Reverse a Number");
                        Reverse rev = new Reverse();
                        Reverse.reverse();
                        break;

                    case 5:
                        Console.WriteLine("Coupon number");
                        Coupon_Number cn = new Coupon_Number();
                        Coupon_Number.coupon_Number();
                        break;

                    case 6:
                        Console.WriteLine("Stop_Watch");
                        Stop_Watch t = new Stop_Watch();
                        Stop_Watch.stop_Watch();
                        break;

                    case 7:
                        Console.WriteLine("Temparature_Conversion");
                        Temparature_Conversion tem = new Temparature_Conversion();
                        Temparature_Conversion.temp();
                        break;

                    case 8:
                        Console.WriteLine("Day _Of_Week");
                        Day_Of_Week d = new Day_Of_Week();
                        Day_Of_Week.day_Of_Week();
                        break;

                    case 9:
                        Console.WriteLine("Vending_Machine");
                        Vending_Machine v = new Vending_Machine();
                        Vending_Machine.vending();
                        break;

                    case 10:
                        Console.WriteLine("Monthly_Payment");
                        Monthly_Payment m = new Monthly_Payment();
                        Monthly_Payment.monthly_payment();
                        break;

                    default:
                        Console.WriteLine("Thank you!");
                        break;
                }
            }
        }
    }
}

