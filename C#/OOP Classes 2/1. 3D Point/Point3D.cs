using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private static readonly Point3D startPoint=new Point3D(0,0,0);

        public Point3D StartPoint
        {
            get { return startPoint; }
        }

        public Point3D(int x, int y, int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.AppendFormat("{0}, ", X);
            print.AppendFormat("{0}, ", Y);
            print.AppendFormat("{0}", Z);
            return print.ToString(); ;
        }
    }

