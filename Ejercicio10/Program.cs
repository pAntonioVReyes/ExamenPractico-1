using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado("Jacobo", "Agami", 500);
            Empleado empleado2 = new Empleado("Alvaro", "Gonzáles", 400);
            Empleado empleado3 = new Empleado("Mario", "Ramón", 300);

            Console.WriteLine("Nombre del empleado: "+empleado1.Nombre+" "+empleado1.Apellido+"\n Sueldo diario: "+empleado1.SueldoDiario+"\n Sueldo total: " + empleado1.CalculaSueldo(15));
            Console.WriteLine("Nombre del empleado: " + empleado2.Nombre + " " + empleado2.Apellido + "\n Sueldo diario: " + empleado2.SueldoDiario + "\n Sueldo total: " + empleado2.CalculaSueldo(20));
            Console.WriteLine("Nombre del empleado: " + empleado3.Nombre + " " + empleado3.Apellido + "\n Sueldo diario: " + empleado3.SueldoDiario + "\n Sueldo total: " + empleado3.CalculaSueldo(31));
            Console.ReadKey();
        }
    }
}
