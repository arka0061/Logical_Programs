using System;

public class Perfect
{
    public static void  perfect()
    {
        int number;
        int sum = 0;
        Console.Write("Enter the Number");
        number = Convert.ToInt32(Console.ReadLine());
        int number_original = number;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == number_original)
        {
            Console.WriteLine("The number is a"+" "+ number+" "+"is a perfect number :");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number is a" + " " + number +" "+"is not a perfect number :");
            Console.ReadLine();
        }
    }
}
