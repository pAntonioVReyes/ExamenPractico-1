using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        public static long factorial(int num) 
        {
            if (num == 0) return 1;
            
            return factorial(num - 1) * num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("El factorial es: " + factorial(4));
            Console.WriteLine("El factorial es: " + factorial(1));
            Console.WriteLine("El factorial es: " + factorial(18));
            Console.WriteLine("El factorial es: " + factorial(10));
            Console.WriteLine("El factorial es: " + factorial(5));
            Console.WriteLine("El factorial es: " + factorial(3));
            Console.ReadKey();
        }
    }
}
