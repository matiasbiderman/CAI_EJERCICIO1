using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;

            Numero num = new Numero();
            a = ServValidac.PedirInt("Ingrese primer numero");
            b = ServValidac.PedirInt("Ingrese segundo numero");
            
            result = num.operacion(a, b);

            Console.WriteLine(result);

        }
    }

    public class Numero
    {
        public double operacion(double a, double b)
        {
            double resultado;
            resultado = (a + b) * (a - b);
            return resultado;
        }
    }

}
