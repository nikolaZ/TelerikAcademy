using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Path
{
    private readonly List<Point3D> path = new List<Point3D>();

    public List<Point3D> PathProp
    { get { return this.path; } }

    public void Add(Point3D point)
    {
        path.Add(point);
    }
    public void Clear()
    {
        path.Clear();
    }
    public override string ToString()
    {
        int i = 0;
        StringBuilder print = new StringBuilder();
        foreach (var item in path)
        {
            i++;
            print.AppendLine();
            print.AppendFormat("{0}. ", i);
            print.Append(item.ToString());
        }
        return print.ToString();
    }
}

