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
    private decimal? price;

    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null)
    {
    }
    public GSM(string model, string manufacturer, string owner)
        : this(model, manufacturer, owner, null)
    {
    }
    public GSM(string model, string manufacturer, string owner, decimal? price)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }
    public GSM(string model, string manufacturer, string owner, decimal? price, Battery battery, Display display)
        : this(model, manufacturer, owner, price)
    {
        this.battery = battery;
        this.display = display;
    }


    public string Model
    {
        get { return this.model; }
        set
        {
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
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value.Length > 0 || value == null)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }
    public string Owner
    {
        get { return this.owner; }
        set
        {
            if (value.Length > 0 || value == null)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }
    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if ((value > 0 && value < decimal.MaxValue) || value == null)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Wrong input");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Model: {0}, Manufucturer: {1}, Owner: {2}, \nPrice: {3}",
this.model, this.manufacturer, this.owner, this.price, this.price);
    }

}

