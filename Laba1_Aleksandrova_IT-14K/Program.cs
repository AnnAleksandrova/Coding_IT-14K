using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1 
{
    class Program
    {
        static void Main(string[] args)
        {
           //вариант 2
            const double x=1.825, y=18.225, z=-3.298;
            double g, w;
            g = Math.Abs(Math.Pow(x,y/x) - Math.Cbrt(y/x));
            w = (y-x)*((y-z)/(1+Math.Pow(y-x,2)));
            Console.WriteLine("g={0,9:F3}; w={1,8:F4}", g, w);
            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }
    }
}


