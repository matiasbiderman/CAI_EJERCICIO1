using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros;
            cantidadNumeros = ServValidac.PedirInt("Ingrese cantidad de numeros a validar");
            string mensaje;

            mensaje = ValidadorNumero.ValidoNumero(cantidadNumeros);

            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }


    static class ValidadorNumero
    {
        public static string ValidoNumero(int cantnumeros)
        {
            List<int> Numeros = new List<int>();
            int ingresados = 0;
            int numero;
            string retorno = "";

            while (ingresados < cantnumeros)
            {
                numero = ServValidac.PedirInt("Ingrese un numero");
                Numeros.Add(numero);
                ingresados++;
            }

            Numeros.Sort();

            if (Numeros.Count % 2 == 0)
            {
                retorno = "el numero mas chico es " + Numeros[0] + ", el numero mas grande es " + Numeros[Numeros.Count - 1] +
                    " y los valores intermedios son " + Numeros[Numeros.Count / 2 - 1] + " y " + Numeros[Numeros.Count / 2];
            }
            else
            {
                retorno = "el numero mas chico es " + Numeros[0] + ", el numero mas grande es " + Numeros[Numeros.Count - 1] + ", valor intermedio " + Numeros[(int)Math.Floor((decimal)Numeros.Count / 2)];

            }

            return retorno;
        }
    }
}
