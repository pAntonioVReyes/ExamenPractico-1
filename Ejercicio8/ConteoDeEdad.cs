using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class ConteoDeEdad
    {
        
        static void Main(string[] args)
        {
            bool salir = false;
            var lista_Edad = new List<int>();
            var lista_Mayores = new List<int>();
            var lista_Menores = new List<int>();

            do {


                Console.WriteLine("Ingresa tu edad \n");
                int edad = int.Parse(Console.ReadLine());

                lista_Edad.Add(edad);

                if (edad > 18)
                {
                    lista_Mayores.Add(edad);
                }
                else
                {
                    lista_Menores.Add(edad);
                }

                Console.Clear();

                Console.WriteLine("Finalizar? Si / No");
                string opcion = Console.ReadLine();

                if (opcion.Equals("Si")) { salir = true; }

                Console.Clear();

            } while (salir == false);

            Console.WriteLine("El total de mayores de edad de la lista de personas es de : " + lista_Mayores.Count);
            Console.WriteLine("El total de menores de edad de la lista de personas es de : " + lista_Menores.Count);
            Console.WriteLine("El total de personas en la lista es de : " + lista_Edad.Count);
            Console.ReadKey();
        }
        
    }
}
