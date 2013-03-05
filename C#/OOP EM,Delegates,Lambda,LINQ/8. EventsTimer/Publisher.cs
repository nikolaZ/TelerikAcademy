using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class Publisher
{
    public int interval { get; set; }
    public int times { get; set; }
    public event EventHandler<EventMessage> RaiseCustomEvent;
    private string message ="\"Process DONE!\"";
    public void Start(int interval, int timesLast)
    {  
        OnRaiseCustomEvent(new EventMessage(this.message),interval,timesLast);
    }
    protected virtual void OnRaiseCustomEvent(EventMessage message,int interval,int timesLast)
    {
        EventHandler<EventMessage> handler = RaiseCustomEvent;
            if (handler != null)
            {
                message.Message += String.Format(" at {0}", DateTime.Now.ToString());
                handler(this, message);
                message.Message = string.Empty;
                message.Message += this.message;
            }
    }

    public void DoWork()
    {
        int ticks = this.times;
        while (ticks > 0)
        {
            Thread.Sleep(this.interval*1000);
            ticks--;
            Start(this.interval,ticks);
        }
    }
}