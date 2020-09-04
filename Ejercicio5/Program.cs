using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            int numerouno;
            int numerodos;
            string aux;

            do
            {
                aux = "";
                do
                {
                    Console.WriteLine("Ingrese primer numero");
                    if (!int.TryParse(Console.ReadLine(), out numerouno))
                    {
                        numerouno = -1;
                    }
                    string numerounostr = numerouno.ToString();
                    int digitos = numerounostr.Length;

                    if (digitos != 5)
                    {
                        Console.WriteLine("Ingrese un numero de 5 digitos");
                    }
                    else
                    {
                        for (int i = numerounostr.Length - 1; i >= 0; i--)
                        {
                            aux = aux + numerounostr[i];
                        }
                    }
                } while (numerouno == -1);

                do
                {
                    Console.WriteLine("Ingrese segundo numero");
                    if (!int.TryParse(Console.ReadLine(), out numerodos))
                    {
                        numerodos = -1;
                    }
                    string numerounostr = numerodos.ToString();
                    int digitos = numerounostr.Length;

                    if (digitos != 5)
                    {
                        Console.WriteLine("Ingrese un numero de 5 digitos");
                    }


                } while (numerodos == -1);

                if (aux == numerodos.ToString())
                {
                    Console.WriteLine("ambos numeros son numeros invertidos");
                }
                else
                {
                    Console.WriteLine("no son numeros invertidos");
                }

            } while (numerouno != -1 && numerodos != -1);


            Console.ReadKey();
        }
    }
}
