using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.cs
{
    public struct point
    {
        public double x;
        public double y;
    };
    public class Triangle
    {

        public point[] points;
        public double[] side;
        public double[] angle = new double[3];
        Random r;
        public Triangle(int a)
        {
            r = new Random(a);
            points = new point[3];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = r.Next(0, 100);
                points[i].y = r.Next(0, 100);
            }
        }
        public void PrintPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x}   \t  Y = {points[i].y}");
            }
        }
        public void SideLength()
        {
            side = new double[3];
            for (int i = 0; i < 3; i++)
            {
                side[i] = Math.Sqrt(Math.Pow(points[(i + 1) % 3].x - points[i].x, 2) + Math.Pow(points[(i + 1) % 3].y - points[i].y, 2));
            }
        }
        public void PrintSide()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + " side length = " + side[i]);
            }
        }
        public bool IsExists()
        {
            bool result = false;
            if ((side[0] + side[1]) > side[2])
            {
                if ((side[0] + side[2]) > side[1])
                {
                    if ((side[2] + side[1]) > side[0]) result = true;
                    /*Console.WriteLine("exist");*/
                }
            }
            return result;
            //else Console.WriteLine("doesn't exist");
        }
        public double GetPerimeter()
        {
            return side[0] + side[1] + side[2];
        }
        public double GetSquare()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
        }
        public void GetAngles()
        {
            angle[0] = Math.Acos((Math.Pow(side[0], 2) + Math.Pow(side[2], 2) - Math.Pow(side[1], 2)) / (2 * side[0] * side[2])) * 180 / Math.PI;
            angle[1] = Math.Acos((Math.Pow(side[0], 2) + Math.Pow(side[1], 2) - Math.Pow(side[2], 2)) / (2 * side[0] * side[1])) * 180 / Math.PI;
            angle[2] = 180 - angle[0] - angle[1];
        }
        public void PrintAngles()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(angle[i]);
            }
        }
        //public void PrintInfo()
        //{

        //    PrintPoints();
        //    PrintSide();
        //    PrintAngles();
        //    Console.WriteLine("Perimeter = " + GetPerimeter());
        //    Console.WriteLine("Suare = " + GetSquare());
        //    Console.WriteLine("----------------------------------");
        //}
        public string PrintData()
        {
            string data = "";

            for (int i = 0; i < 3; i++)
            {
                data += $"X = { points[i].x }\t Y = { points[i].y }\n";
            }

            for (int i = 0; i < 3; i++)
            {
                data += $"{i + 1} Side = {side[i]:N2}\n";
            }
            data += $"Angle 1 = {angle[0]:N2}\n";
            data += $"Angle 2 = {angle[1]:N2}\n";
            data += $"Angle 3 = {angle[2]:N2}\n";
            data += $"Perimeter = {GetPerimeter():N2}\n";
            data += $"Suare = {GetSquare():N2}\n";

            //data += $"------------------------------------------\n";

            return data;

        }
    }
}
