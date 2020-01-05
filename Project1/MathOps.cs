using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public class MathOps
    {
        public int Add2Numbs(int x, int y)
        {
            return x + y;
        }
        public int Add3Numbs(int x, int y, int z)
        {
            return x + y + z;
        }

        public long Imp3Numbs(long x, long y, long z)
        {
            return x * y * z;
        }

        public decimal Imp2Numbs(decimal x, decimal y)
        {
            return x * y;
        }

        public double AddArr(double[] x)
        {
        double suma = 0;
        for (int i=0; i<x.Length; i++)
            {
            suma += x[i];
            }
        return suma;
        }

        public short ImpArr(short[] x)
        {
            short sum = 1;
            for (int i=0; i<x.Length; i++)
            {
                sum *= x[i];
            }
            return sum;
        }
    }
}
