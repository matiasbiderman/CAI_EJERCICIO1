using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    static class ServValidac
    {
        public static double PedirInt(string mensaje)
        {
            double valor;
            do
            {
                Console.WriteLine(mensaje);
                if (!double.TryParse(Console.ReadLine(), out valor))
                {
                    valor = - 1;
                }
                if (valor < 0)
                {
                    Console.WriteLine("ingrese un valor valido");
                }

            } while (valor < 0);
            return valor;
        }
    }
}
