//* Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above(Timer) using
//.NET events and following the best practices.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class EventProgram
{
    static void Main(string[] args)
    {

        Publisher pub = new Publisher();
        Subscriber sub1 = new Subscriber("Subscriber1", pub);
        pub.interval = 2;
        pub.times = 5;

        Console.WriteLine("Event Started");

        Thread Timer = new Thread(new ThreadStart(pub.DoWork));
        Timer.Start();

        MainProcess(pub.times);

        
    }
    static void MainProcess(int times)
    {
        for (int i = 0; i <times ; i++)
        {
            Thread.Sleep(1300);
            Console.WriteLine("This process is running parallel");
        }   
    }

}