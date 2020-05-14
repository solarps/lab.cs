using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.cs
{
    public class Equilateral : Triangle
    {
        public double delta = 0.1;

        //point[] points; 
        Random r = new Random();
        public Equilateral(int a) : base(a) { }
        public Equilateral() { }
        public bool IsEqualSide()
        {
            bool result = false;
            //side[0] = 1;
            //side[1] = 1;
            //side[2] = 1;

            if (Math.Abs(side[0] - side[1]) < delta && Math.Abs(side[0] - side[2]) < delta && (side[0] > delta))
            {
                result = true;
            }
            return result;
        }
        public double GetMed()
        {
            return side[0] * Math.Sqrt(3) / 2;
        }
        public Equilateral Read(BinaryReader br)
        {
            Equilateral temp = new Equilateral();

            for (int i = 0; i < points.Length; i++)
            {
                temp.points[i].x = br.ReadInt32();
                temp.points[i].y = br.ReadInt32();
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
