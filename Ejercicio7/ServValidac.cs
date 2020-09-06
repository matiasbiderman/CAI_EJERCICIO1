using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    static class ServValidac
    {
        public static int PedirInt(string mensaje)
        {
            int valor;
            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    valor = -9999;
                }
                if (valor < 0)
                {
                    Console.WriteLine("ingrese un valor mayor a 0");
                }

            } while (valor < 0);
            return valor;
        }
    }
}
