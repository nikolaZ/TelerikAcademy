using System;
using System.Threading;

public delegate void Timing();
public class Timer
{
    public int Seconds { get; set; }
    public int TimeLast { get; set; }
    public Timing Clock { get; set; }

    public Timer(Timing clock, int seconds)
    {
        this.Clock = clock;
        this.Seconds = seconds;
    }
    public Timer(Timing clock, int seconds, int timeLast)
        : this(clock, seconds)
    {
        this.TimeLast = timeLast;
    }
    public static void Time()
    {
        Console.WriteLine(DateTime.Now);
    }
    public void Start()
    {
        int time = this.TimeLast;
        if (time > 0)
        {
            while (time > 0)
            {
                Thread.Sleep(this.Seconds * 1000);
                time--;
                this.Clock();
            }
        }
        else
        {
            while (true)
            {
                Thread.Sleep(this.Seconds * 1000);
                this.Clock();
            }
        }
    }
}

