using System;

namespace Logical_Programs
{
    class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press 1 to 10 to run the Following programs!");
            Console.WriteLine("Press 1 for Fibonacci!");
            Console.WriteLine("Press 2 for Perfect Number!");
            Console.WriteLine("Press 3 for Prime or not!");
            Console.WriteLine("Press 4 for Reversing a Number");
            Console.WriteLine("Press 5 for Coupon Numbers!");

            Console.WriteLine("Press 6 for !");
            Console.WriteLine("Press 7 for Swap_Numbers!");
            Console.WriteLine("Press 8 for Even or Odd!");
            Console.WriteLine("Press 9 for Vowel_Or_Constant!");
            Console.WriteLine("Press 10 for Largest_Among_Three_Numbers!");
            Console.WriteLine("----------------------------------------------------------------------------------------");
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
                     Coupon_Number cn= new Coupon_Number();
                     Coupon_Number.coupon_Number();
                     break;

                     /* case 6:
                          Console.WriteLine("Quotient and Remainder");
                          Quotient_and_Remainder quo = new Quotient_and_Remainder();
                          Quotient_and_Remainder.Quotient_and_Remainders();
                          break;
                      case 7:
                          Console.WriteLine("Swap Two Numbers");
                          Swap_Number swp = new Swap_Number();
                          Swap_Number.swap();
                          break;

                      case 8:
                          Console.WriteLine("Even Or Odd");
                          Even_odd e = new Even_odd();
                          Even_odd.check();
                          break;
                      case 9:
                          Console.WriteLine("Vowel Or Consonant");
                          Vowel_Consonant v = new Vowel_Consonant();
                          Vowel_Consonant.check();
                          break;
                      case 10:
                          Console.WriteLine("Largest_Among_Three_Numbers");
                          Largest_Three_Numbers l = new Largest_Three_Numbers();
                          Largest_Three_Numbers.check();
                          break;
                      default:
                          Console.WriteLine("Wrong Input!");
                          break;  */
            }
            }
        }
    }

