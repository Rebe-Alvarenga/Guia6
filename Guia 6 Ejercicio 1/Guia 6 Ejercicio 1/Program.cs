using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, res = 0;
            Console.WriteLine("Ingrese el numero a operar");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("SOLO DEBE INGRESAR NUMEROS...AL PRESIONAR UNA TECLA EL PROGRAMA SE CERRARA...");
                Console.ReadKey();
                return;
            }
            for (int i = 1; i < 13; i++)
            {
                res = num * i;
                Console.WriteLine(num + " x " + i + " = " + res);
            }
            Console.ReadKey();
        }
    }
}
