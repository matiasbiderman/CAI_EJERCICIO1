using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cantnumero = 830;
            string lista = "";
            int[] numeros = new int[cantnumero];

            int posicion = 0;
            do
            {
                numeros[posicion] = posicion + 1;
                if ((numeros[posicion] % 5 == 0) && (numeros[posicion] % 3 == 0))
                {
                    lista = numeros[posicion] + "\t - FOOBAR";
                }
                else if (numeros[posicion] % 3 == 0)
                {
                    lista = numeros[posicion] + "\t - FOO";
                }
                else if (numeros[posicion] % 5 == 0)
                {
                    lista = numeros[posicion] + "\t - BAR";
                }
                else
                {
                    lista = numeros[posicion].ToString();
                }
                Console.WriteLine(lista);
                posicion++;
            } while (posicion < cantnumero);

           
           /*
            }*/
        }
    }
}
