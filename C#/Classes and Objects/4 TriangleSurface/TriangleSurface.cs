//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TriangleSurface
    {
        static void Main()
        {
            Menu();
        }
        static double Surface(double a, double h)
        {
            double surface=(a*h)/2;
            return surface;
        }
        static double Surface(double a, double b,double c)
        {
            double halfCircuit = (a +b+c) / 2;
            double surface = Math.Sqrt(halfCircuit * (halfCircuit - a) * (halfCircuit - b) * (halfCircuit - c));
            return surface;
        }
        static double Surface(double a, double b, int alpha)
        {
            double sin=Math.Sin((alpha*Math.PI)/180);
            double surface = (a * b * sin);
            return surface;
        }
        static void Menu()
        {
            Console.WriteLine("Calculate the surface of a triangle: ");
            Console.WriteLine("1. By a side and an altitude");
            Console.WriteLine("2. By three sides");
            Console.WriteLine("3. By two sides and an angle(in degrees) between them");
            Console.WriteLine("Choose from 1. to 3.");
            string choice = Console.ReadLine();
            double sideOne;
            double sideTwo;
            double sideThree;
            double altitude;
            int alpha;
            switch (choice)
            {
                case "1": Console.WriteLine("Enter Side"); sideOne = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Altitude");altitude = double.Parse(Console.ReadLine());
                    Console.WriteLine(Surface(sideOne, altitude));break;
                case "2": Console.WriteLine("Enter Side"); sideOne = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Side"); sideTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Side"); sideThree = double.Parse(Console.ReadLine());
                    Console.WriteLine(Surface(sideOne, sideTwo,sideThree)); break;
                case "3": Console.WriteLine("Enter Side"); sideOne = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Side"); sideTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Angle in degrees"); alpha = int.Parse(Console.ReadLine());
                    Console.WriteLine(Surface(sideOne, sideTwo,alpha)); break;
                default: Console.WriteLine("Invalid Choice!"); Menu();
                    break;
            }
        }
        

    }

