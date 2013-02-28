using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Call
    {
        private DateTime time;
        private string dialedNumber;
        private uint duration;

        public Call(DateTime time, string dialedNumber, uint duration)
        {
            this.time = time;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        

        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
            //set { dateAndTime = DateTime.Parse(value.ToString()); }
        }
        public string DialedNumber 
        {
            get { return this.dialedNumber; }
            set
            {
                if (value.Length >= 5)
                {
                    this.dialedNumber = value;
                }
            }
        }

        public uint Duration
        {
            get { return this.duration; }
            set
            {
                if (value>0 && value<uint.MaxValue)
                {
                    this.duration = value;
                }
            }
        }
        
    }

