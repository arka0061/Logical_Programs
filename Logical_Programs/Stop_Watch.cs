using System;
using System.Diagnostics;
using System.Threading;
public class Stop_Watch
{
    public static void stop_Watch()
    {
        String check = "";
       

        Boolean counter;
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Press S to begin the stopwatch");
        Console.WriteLine("Press T to stop the stopwatch");
        check = Console.ReadLine();
        if (check== "S")
        {
            stopwatch.Start();
            check = Console.ReadLine();
            
                while(check!="T")
                {
                    Thread.Sleep(1);
                } 
        }
            stopwatch.Stop();
    
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
}