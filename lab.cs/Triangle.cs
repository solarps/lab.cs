using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab.cs
{
    public struct point
    {
        public double x;
        public double y;
    };
    public class Triangle
    {

        public point[] points = new point[3];
        public double[] side = new double[3];
        public double[] angle = new double[3];
        public double Perimeter;
        public double Square;
        Random r;
        public Triangle(int a)
        {
            r = new Random(a);
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = r.Next(0, 100);
                points[i].y = r.Next(0, 100);
            }
        }
        public Triangle() { }
        public void PrintPoints()
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X = {points[i].x}   \t  Y = {points[i].y}");
            }
        }
        public void SideLength()
        {
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
        public void GetPerimeter()
        {
            Perimeter = side[0] + side[1] + side[2];
        }
        public void GetSquare()
        {
            double p = Perimeter / 2;
            Square = Math.Sqrt(p * (p - side[0]) * (p - side[1]) * (p - side[2]));
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
            data += $"Perimeter = {Perimeter:N2}\n";
            data += $"Suare = {Square:N2}\n";

            //data += $"------------------------------------------\n";

            return data;

        }
        public void Write(BinaryWriter bw)
        {
            for (int i = 0; i < points.Length; i++)
            {
                bw.Write(points[i].x);
                bw.Write(points[i].y);
            }
            for (int i = 0; i < points.Length; i++)
            {
                bw.Write(side[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                bw.Write(angle[i]);
            }
            bw.Write(Perimeter);
            bw.Write(Square);
        }
        public Triangle Read(BinaryReader br)
        {
            Triangle temp = new Triangle();

            for (int i = 0; i < points.Length; i++)
            {
                temp.points[i].x = br.ReadDouble();
                temp.points[i].y = br.ReadDouble();
            }
            for (int i = 0; i < points.Length; i++)
            {
                temp.side[i] = br.ReadDouble();
            }
            for (int i = 0; i < 3; i++)
            {
                temp.angle[i] = br.ReadDouble();
            }
            temp.Perimeter = br.ReadDouble();
            temp.Square = br.ReadDouble();

            return temp;
        }
    } 
}
