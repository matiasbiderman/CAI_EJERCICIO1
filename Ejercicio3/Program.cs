using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            do
            {
                string aux = "";
                do
                {
                    Console.WriteLine("ingrese palaba que sea palindromo");
                    palabra = Console.ReadLine();
                    if (palabra == "")
                    {
                        Console.WriteLine("indique una palabra");
                    }

                } while (palabra == "");

                for (int i = palabra.Length - 1; i >= 0; i--)
                {
                    aux = aux + palabra[i];
                }
                if (aux == palabra)
                {
                    Console.WriteLine("ES PALINDROMO");
                }
                else
                {
                    Console.WriteLine("NO ES PALINDROMO");
                }
            } while (palabra != "");
        }
    }
}
