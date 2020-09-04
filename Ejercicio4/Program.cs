using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1;
            string palabra2;
            string aux1;
            string aux2;
            do
            {
                aux1 = "";
                Console.WriteLine("Ingresar palabra 1");
                palabra1 = Console.ReadLine().ToUpper();
                if(palabra1 == "")
                {
                    Console.WriteLine("Ingresar palabra1 valida");
                }


                for (int i = palabra1.Length - 1; i >= 0; i--)
                {
                    aux1 = aux1 + palabra1[i];

                }


            } while (palabra1 == "");

            do
            {
                aux2 = "";
                Console.WriteLine("Ingresar palabra 2");
                palabra2 = Console.ReadLine().ToUpper();
                if (palabra2 == "")
                {
                    Console.WriteLine("Ingresar palabra2 valida");
                }
               /* for (int i = 1; i >= palabra2.Length; i++)
                {
                    aux2 = aux2 + palabra2[i];

                }*/
            } while (palabra2 == "");

            if (aux1 == palabra2)
            {
                Console.WriteLine("es un anagrama");
            }
            else
            {
                Console.WriteLine(" NO es un anagrama");
            }
        }
    }
}
