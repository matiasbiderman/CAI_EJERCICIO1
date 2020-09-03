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
            bool respuesta = false;
            do
            {
                numeros[posicion] = posicion + 1;
                int numeroEvaluar = numeros[posicion];



                    int contadorDivisores = 0;
                    for (int i = 1; i <= numeroEvaluar; i++)
                    {
                        int numero = numeroEvaluar % i;
                        if (numero == 0)
                        {
                            contadorDivisores++;
                        }
                        if (contadorDivisores > 2)
                        {
                            respuesta = false;
                        }
                        if (numeroEvaluar == i && contadorDivisores <= 2)
                        {
                            respuesta = true;
                        }
                   
                    }
                if ((numeros[posicion] % 3 == 0) && respuesta)
                {
                    lista = numeros[posicion] + " - Es primo y divisible por 3";
                }
                else if (numeros[posicion] % 3 == 0)
                {
                    lista = numeros[posicion] + " - Es divisible por 3";
                }
                else if (respuesta)
                {
                    lista = numeros[posicion] + " - Es primo";
                }
                else
                {
                    lista = numeros[posicion].ToString();
                }
                Console.WriteLine(lista);
                posicion++;
            } while (posicion < cantnumero);
        }
    }
}
