using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Algoritmo
    {
        public static double CalcularPi(int n)
        {
            double pi = 0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            return pi * 4;
        }
    }
}
