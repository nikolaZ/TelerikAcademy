using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class CalcDistance
    {
        public static double Distance(Point3D p,Point3D q)
        {
            double distance = 0;
            distance = Math.Sqrt((Math.Pow((p.X - q.X), 2)) + (Math.Pow((p.Y - q.Y), 2)) + (Math.Pow((p.Z - q.Z), 2)));
            return distance;
        }
    }

