using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Battery
    {
        private string model;
        private byte? hoursIdle;
        private byte? hoursTalk;


        public Battery(string model)
            : this(model, null, null)
        {
        }
        public Battery(string model, byte? hoursIdle)
            : this(model, hoursIdle, null)
        {
        }
        public Battery(string model, byte? hoursIdle, byte? hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public byte? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public byte? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }
        
    }

