using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int cantnumero = 830;
            string lista = "";
            int[] numeros = new int[cantnumero];
            int posicion = 0;
            int cont = 0;
            do
            {
                numeros[posicion] = posicion + 1;

                for (int i = 1; i <= numeros.GetUpperBound(0); i++)
                {
                    if (numeros[posicion] % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2 && numeros[posicion] % 3 == 0)
                {
                    lista = numeros[posicion] + "\t - Es primo y divisible por 3";
                }
                /*else if ()
                {
                    lista = numeros[posicion] + "\t - Es divisible por 3";
                }
                else if (numeros[posicion] % 3 == 0 && cont == 2)
                {
                    lista = numeros[posicion] + "\t - Es primo y divisible por 3";

                }*/
                
                /*else if (numeros[posicion] / numeros[posicion] == 1)
                {
                    lista = numeros[posicion] + "\t - Es primo";
                }*/
                else
                {
                    lista = numeros[posicion].ToString();
                }
                Console.WriteLine(lista);
                posicion++;
                cont = 0;
            } while (posicion < cantnumero);
        }
    }
}
