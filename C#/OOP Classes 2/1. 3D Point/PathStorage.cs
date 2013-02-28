using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


public static class PathStorage
{
    public static void Save(Path pathList)
    {
        StreamWriter write = new StreamWriter(@"d:/text1.txt");
        using (write)
        {
            foreach (var path in pathList.PathProp)
            {
                write.WriteLine(path.ToString());
            }
        }
    }
    public static Path Load()
    {
        StreamReader reader = new StreamReader(@"d:/text.txt");
        Path loadPath = new Path();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] extract = line.Split(',');
                Point3D pointLoaded = new Point3D();
                pointLoaded.X = int.Parse(extract[0].Trim());
                pointLoaded.Y = int.Parse(extract[1].Trim());
                pointLoaded.Z = int.Parse(extract[2].Trim());
                loadPath.Add(pointLoaded);
                line = reader.ReadLine();
            }
        }
        return loadPath;
    }
}

