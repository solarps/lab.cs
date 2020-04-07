using System;
using System.Collections.Generic;
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
    }
}
