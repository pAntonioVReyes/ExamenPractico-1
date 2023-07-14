using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioDeLetras
{
    internal class Program
    {

        public static string TransformarLetra(string letra) 
        {
            if (letra == "a") { return letra = "b"; }
            else if (letra == "b") { return letra = "c"; }
            else if (letra == "c") { return letra = "d"; }
            else if (letra == "d") { return letra = "e"; }
            else if (letra == "e") { return letra = "f"; }
            else if (letra == "f") { return letra = "g"; }
            else if (letra == "g") { return letra = "h"; }
            else if (letra == "h") { return letra = "i"; }
            else if (letra == "i") { return letra = "j"; }
            else if (letra == "j") { return letra = "k"; }
            else if (letra == "k") { return letra = "l"; }
            else if (letra == "l") { return letra = "m"; }
            else if (letra == "m") { return letra = "n"; }
            else if (letra == "n") { return letra = "ñ"; }
            else if (letra == "ñ") { return letra = "o"; }
            else if (letra == "o") { return letra = "p"; }
            else if (letra == "p") { return letra = "q"; }
            else if (letra == "q") { return letra = "r"; }
            else if (letra == "r") { return letra = "s"; }
            else if (letra == "s") { return letra = "t"; }
            else if (letra == "t") { return letra = "u"; }
            else if (letra == "u") { return letra = "v"; }
            else if (letra == "v") { return letra = "w"; }
            else if (letra == "w") { return letra = "x"; }
            else if (letra == "x") { return letra = "y"; }
            else if (letra == "y") { return letra = "z"; }
            else if (letra == "z") { return letra = "a"; }
            return letra;
        }

        public static void CambiarLetras(string palabra) 
        {
            char[] letras = palabra.ToCharArray();
            var listapalabranew = new List<string>();

            for (int i=0; i<letras.Length; i++) 
            {
                string nuevaLetra = TransformarLetra(letras[i].ToString());
                listapalabranew.Add(nuevaLetra);
            }
             string letraInvertida= string.Join("", listapalabranew);
             Console.WriteLine(letraInvertida);
        }

        static void Main(string[] args)
        {
            CambiarLetras("hola");
            CambiarLetras("Hola");
            Console.ReadKey();
        }
    }
}
