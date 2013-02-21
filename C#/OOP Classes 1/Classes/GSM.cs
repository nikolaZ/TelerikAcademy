using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class GSM
    {
        public Battery battery = new Battery();
        public Display display = new Display();

        private string model;
        private string manufacturer;
        private string owner;
        private decimal price;


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
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }

