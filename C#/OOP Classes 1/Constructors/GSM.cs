using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class GSM
    {
        public Battery battery = new Battery(null,null,null);
        public Display display = new Display(null,null);

        private string model;
        private string manufacturer;
        private string owner;
        private decimal? price;

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer, owner, null, null, null)
        {
        }
        public GSM(string model, string manufacturer, string owner, decimal? price)
            : this(model, manufacturer, owner, price,null,null)
        {
        }
        public GSM(string model, string manufacturer, string owner, decimal? price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery.Model = battery.Model;
            this.battery.HoursIdle = battery.HoursIdle;
            this.battery.HoursTalk = battery.HoursTalk;
            this.display.Size = display.Size;
            this.display.NumberOfColors = display.NumberOfColors;
        }

        public string Model
        {
	        get{ return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }

