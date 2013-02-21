using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Display
    {
        private float size;//in inches
        private float numberOfColors;//in milions


        public float Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public float NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }

