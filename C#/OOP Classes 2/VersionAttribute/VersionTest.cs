using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

[Version(2, 1)]
public class VersionTest
{
    [Version(1, 135)]
    public static void TestMethod()
    {
    }
    [Version(2, 154)]
    public enum NestedEnum { }
    [Version(2, 155)]
    public enum NestedEnum2 { }
    [Version(1, 1)]
    public static void Main(string[] args)
    {
        Type typeClass = typeof(VersionTest);
        object[] classAttr =
          typeClass.GetCustomAttributes(false);
        foreach (Version attr in classAttr)
        {
            Console.WriteLine("Class \"{0}\" version is {1}", typeClass.Name, attr.Versions);
        }
        Type enumTest = typeof(Test);
        object[] enumTestAttr =
          enumTest.GetCustomAttributes(false);
        foreach (Version attr in enumTestAttr)
        {
            Console.WriteLine("Enumeration \"{0}\" version is {1}", enumTest.Name, attr.Versions);
        }
        MethodInfo[] infoMethods = typeClass.GetMethods(BindingFlags.Static | BindingFlags.Public);
        foreach (MethodInfo method in infoMethods)
        {
            object[] methodAttributes = method.GetCustomAttributes(false);
            Console.WriteLine("Method \"{0}\" version is {1}",method.Name,(methodAttributes[0] as Version).Versions);
        }
        Type[] enums = new Type[] { typeClass.GetNestedType("NestedEnum"), typeClass.GetNestedType("NestedEnum2") };
        foreach (var item in enums)
        {
            object[] nestedEnum = item.GetCustomAttributes(false);
            Console.WriteLine("\"{0}\" version is {1}", item.Name, (nestedEnum[0] as Version).Versions);
        }
    }
}
[Version(2, 35)]
public enum Test { }

