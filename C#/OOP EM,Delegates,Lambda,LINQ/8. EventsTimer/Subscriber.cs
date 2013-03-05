using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Subscriber
{
    private string id;
    public Subscriber(string ID, Publisher pub)
    {
        id = ID;
        pub.RaiseCustomEvent += HandleCustomEvent;
    }

    // Define what actions to take when the event is raised. 
    void HandleCustomEvent(object sender, EventMessage e)
    {
        Console.WriteLine(id + " received this message: {0}", e.Message);
    }
}
