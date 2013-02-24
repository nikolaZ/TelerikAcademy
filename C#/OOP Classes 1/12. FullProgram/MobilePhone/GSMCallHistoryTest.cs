using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class GSMCallHistoryTest
    {
        static void Main()
        {
            GSM phone = new GSM("Desire X", "HTC");
            
            phone.AddCall(DateTime.Now, "0899789987", 456);
            phone.AddCall(new DateTime(2013, 2, 16), "0899233987", 350);
            phone.AddCall(new DateTime(2013,2,22), "0899789345", 2);
            Console.WriteLine(phone.ToString());
            phone.ShowCallHistory();
            phone.CalcPrice(0.37M);
            phone.RemoveLongestCall();
            phone.CalcPrice(0.37M);
            phone.ClearHistory();
            phone.ShowCallHistory();
        }
    }

