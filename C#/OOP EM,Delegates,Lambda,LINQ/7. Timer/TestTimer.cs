//Using delegates write a class Timer that has can execute certain method at each t seconds.
using System;
using System.Threading;


    public class TestTimer
    {
        static void Main(string[] args)
        {
            Timing test = Timer.Time;
            Console.WriteLine("The time now is:");
            Timer testTime = new Timer(test, 2);//You can call the constructor without timeLast, which repeats inifinite times
            Thread timer = new Thread(new ThreadStart(testTime.Start));
            timer.Start();
        }
    }

