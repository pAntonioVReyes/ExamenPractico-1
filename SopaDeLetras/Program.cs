using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SopaDeLetras
{
    internal class Program
    {
        public static void sopaDeLetras(string palabra) 
        {
            //Metodo de LINQ
            string ordenado = new string(palabra.OrderBy(x => x).ToArray());
            Console.WriteLine("Nuevo ordenamiento : "+ordenado);
        }

        /* public static void sopaDeLetrasManual(string plabra) 
        {
            char[] letras = plabra.ToCharArray();
            char auxiliar;
            int final = letras.Length-1;

            for (int i=0; i <= final; i++) 
            {
                    auxiliar = letras[i];
                    letras[i] = letras[final];
                    letras[final] = auxiliar;
                    final--;
            }

            string sopaDeLetras = string.Join("", letras);
            Console.WriteLine(sopaDeLetras);
        }  */

        static void Main(string[] args)
        {
            sopaDeLetras("sopa");
           /* sopaDeLetrasManual("sopa"); */
            Console.ReadKey();
        }
    }
}
