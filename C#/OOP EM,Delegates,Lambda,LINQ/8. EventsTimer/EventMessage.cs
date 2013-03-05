using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EventMessage : EventArgs
{
    public string message;
    public EventMessage(string str)
    {
        this.message = str;
    }
    public string Message
    {
        get { return this.message; }
        set { this.message = value; }
    }
}

