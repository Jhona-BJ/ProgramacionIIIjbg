using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("menor de {0}, {1} y {2} es {3}\n", 2, 3, 4, Menor(2, 3, 4));
            
            Console.WriteLine("Menor de {0}, {1} y {2} es {3}\n",
                  3.1, 4.6, 2.3, Menor(3.1, 4.6, 2.3));
                Console.WriteLine("Menor de {0}, {1} y {2} es {3}\n",
                   "Juan", "Pedro", "Maria", Menor("Juan", "Pedro", "Maria"));
                Console.ReadKey();
            


        }

        private static T Menor<T>(T x, T y, T z)
           where T : IComparable<T>
        {
            T min = x;
            if (y.CompareTo(min) < 0)
                min = y;
            if (z.CompareTo(min) < 0)
                min = z;
            return min;
        }
        private static T Menor2<T>(T x, T y, T z)
           where T : IComparable<T>
        {
            T min2 = x;
            if (y.CompareTo(min2) < 0)
                min2 = y;
            
            return min2;
        }
    }
}
