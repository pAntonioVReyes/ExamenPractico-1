using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double SueldoDiario { get; set; }

        public Empleado() { }
        public Empleado(string nombre, string apellido, double sueldodiario) 
        { 
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.SueldoDiario = sueldodiario;
        }

        public double CalculaSueldo(int diasTrabajados) 
        {
            return SueldoDiario * diasTrabajados;
        }

    }
}
