using System;

namespace Desafio_Dirmod
{
    class Program
    {
        static void Main(string[] args)
        {
            string ban="1";
            while (ban=="1")
            {
                Console.WriteLine("Ingrese el texto que desee codificar");
                Console.WriteLine ("");
                string palabra = Console.ReadLine();
                 Console.WriteLine ("");
                string conversion = Codificador.codificar(palabra.ToUpper());
                Console.WriteLine("Usted ingresò: "+palabra);
                Console.WriteLine ("El equivalente codificado es: "+conversion);
                Console.WriteLine ("-----------------------------");
                Console.WriteLine ("");
                Console.WriteLine ("Ingrese un 1 para realizar otra conversion");
                Console.WriteLine ("Ingrese un cualquier otra tecla para salir ");
                Console.WriteLine ("");
                Log.logThis(palabra, conversion);
                ban=Console.ReadLine();
            }
           
          
        }
    }
}
