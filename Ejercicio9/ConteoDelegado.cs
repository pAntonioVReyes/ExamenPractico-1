using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class ConteoDelegado
    {
        static void Main(string[] args)
        {
            var candidato1 = new List<int>();
            var candidato2 = new List<int>();
            var candidato3 = new List<int>();
            var votonulo = new List<int>();
            int votantes = 0;
            do
            {
                Console.WriteLine("Voto del candidato a delegado \n 1: Candidato 1 \n 2: Candidato 2 \n 3: Candidato 3");
                int elecion = int.Parse(Console.ReadLine());

                if (elecion == 1)
                { candidato1.Add(1); votantes++; }
                else if (elecion == 2)
                { candidato2.Add(1); votantes++; }
                else if (elecion == 3)
                { candidato3.Add(1); votantes++; }
                else if ( elecion > 3) 
                { votonulo.Add(1); votantes++; }
                
                Console.WriteLine("Voto registrado");
                Console.ReadKey();
                Console.Clear();

            } while (votantes < 10);

            if (candidato1.Count > candidato2.Count && candidato1.Count > candidato3.Count)
            {
                Console.WriteLine("El candidato 1 gana con un total de : " + candidato1.Count + " votos");

                if (candidato2.Count > candidato3.Count)
                {
                    Console.WriteLine("El candidato 2 queda en segundo lugar con un total de : " + candidato2.Count + " Votos");
                    Console.WriteLine("El candidato 3 queda en tercer lugar con un total de : " + candidato3.Count + " Votos");
                }
                else if (candidato3.Count > candidato2.Count)
                {
                    Console.WriteLine("El candidato 3 queda en segundo lugar con un total de : " + candidato3.Count + " Votos");
                    Console.WriteLine("El candidato 2 queda en tercer lugar con un total de : " + candidato2.Count + " Votos");
                }
                else if (candidato2.Count == candidato3.Count)
                {
                    Console.WriteLine("Los candidatos 2 y 3 empataron con un total de : " + candidato2.Count + " votos");
                }
            }
            else if (candidato2.Count > candidato1.Count && candidato2.Count > candidato3.Count)
            {
                Console.WriteLine("El candidato 2 gana con un total de :" + candidato2.Count + " votos");

                if (candidato1.Count > candidato3.Count)
                {
                    Console.WriteLine("El candidato 1 queda en segundo lugar con un total de : " + candidato1.Count + " Votos");
                    Console.WriteLine("El candidato 3 queda en tercer lugar con un total de : " + candidato3.Count + " Votos");
                }
                else if (candidato3.Count > candidato1.Count)
                {
                    Console.WriteLine("El candidato 3 queda en segundo lugar con un total de : " + candidato3.Count + " Votos");
                    Console.WriteLine("El candidato 1 queda en tercer lugar con un total de : " + candidato1.Count + " Votos");
                }
                else if (candidato1.Count == candidato3.Count)
                {
                    Console.WriteLine("Los candidatos 1 y 3 empataron con un total de : " + candidato1.Count + " votos");
                }
            }
            else if (candidato3.Count > candidato2.Count && candidato3.Count > candidato1.Count)
            {
                Console.WriteLine("El candidato 3 gana con un total de :" + candidato3.Count + " votos");

                if (candidato1.Count > candidato2.Count)
                {
                    Console.WriteLine("El candidato 1 queda en segundo lugar con un total de : " + candidato1.Count + " Votos");
                    Console.WriteLine("El candidato 2 queda en tercer lugar con un total de : " + candidato2.Count + " Votos");
                }
                else if (candidato2.Count > candidato1.Count)
                {
                    Console.WriteLine("El candidato 2 queda en segundo lugar con un total de : " + candidato2.Count + " Votos");
                    Console.WriteLine("El candidato 1 queda en tercer lugar con un total de : " + candidato1.Count + " Votos");
                }
                else if (candidato1.Count == candidato2.Count)
                {
                    Console.WriteLine("Los candidatos 1 y 2 empataron con un total de : " + candidato1.Count + " votos");
                }
            }
            else if (candidato1.Count == candidato2.Count && candidato1.Count == candidato3.Count) 
            {
                Console.WriteLine("Los tres candidatos quedaron empates con un total de :"+candidato1.Count+" votos");
            }
            Console.WriteLine("Total de votos nulos : " + votonulo.Count);
            Console.WriteLine("Total de votos : "+votantes);
            Console.ReadKey();

        }
    }
}
