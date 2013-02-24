using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Display
    {
        private float? size;//in inches
        private float? numberOfColors;//in milions

        public Display():this(null,null)
        {
        }
        public Display(float? size)
            : this(size, null)
        {
        }
        public Display(float? size, float? numberOfColors)
        {
            this.numberOfColors = numberOfColors;
            this.size = size;
        }
        public float? Size
        {
            get { return this.size; }
            set
            {
                if ((value > 0 && value < float.MaxValue) || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }

        public float? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if ((value > 0 && value < float.MaxValue) || value == null)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException("Wrong input");
                }
            }
        }
    }

