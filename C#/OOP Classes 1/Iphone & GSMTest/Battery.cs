using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public enum BatteryType 
    { 
        Li_Ion, NiMH, NiCd
    }
    public class Battery
    {
        private string model;
        private BatteryType type;
        private byte? hoursIdle;
        private byte? hoursTalk;

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public Battery()
        {
        }
        public Battery(string model, byte? hoursIdle)         
        {
            this.model = model;
            this.hoursIdle = hoursIdle;

        }
        public Battery(string model, byte? hoursIdle, byte? hoursTalk,BatteryType type): this(model, hoursIdle)
        {
            this.hoursTalk = hoursTalk;
            this.type = type;
        }


        public string Model
        {
            get { return this.model; }
            set{
                if (value.Length > 0 || value == null)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public byte? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if ((value > 0 && value < byte.MaxValue) || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        public byte? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if ((value > 0 && value < byte.MaxValue) || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
        
    }

