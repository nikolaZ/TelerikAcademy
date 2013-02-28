using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Point3D p = new Point3D();
            Point3D q = new Point3D(4, 4, 4);
            Console.WriteLine(CalcDistance.Distance(p, q));
            Path path = new Path();
            path.Add(p);
            path.Add(q);
            path.Add(new Point3D(9, 9, 9));
            Console.WriteLine(path.ToString());
            PathStorage.Save(path);
            Console.WriteLine(PathStorage.Load().ToString());

        }
    }

