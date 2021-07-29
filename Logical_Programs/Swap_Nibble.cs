using System;
namespace Logical_Programs
{

    public class Swap_Nibble
    {            
            static int swapNibbles(int x)
            {
                return ((x & 0x0F) << 4 |
                        (x & 0xF0) >> 4);
            }
            public static void Nibble()
            {
            Console.WriteLine("Enter a Decimel Number");
            int x = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("The Swapped Nibble is :"+swapNibbles(x));
            }
        }

    }
    


