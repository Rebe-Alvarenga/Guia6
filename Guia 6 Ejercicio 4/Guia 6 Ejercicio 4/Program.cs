using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, neg = 0, pos = 0, quin = 0, res1, par = 0, res2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el numero a evaluar...");
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error de formato. No es un valor numerico...");
                    Console.WriteLine("Al presionar una tecla el programa se cerrara...");
                    Console.ReadKey();
                    return;
                }
                if (num > 0)
                {
                    pos++;
                }
                else if (num < 0)
                {
                    neg++;
                }
                res1 = num % 15;
                if (res1 == 0)
                {
                    quin++;
                }
                res2 = num % 2;
                if (res2 == 0)
                {
                    par++;
                }
                Console.WriteLine("Numeros positivos:       " + pos);
                Console.WriteLine("Numeros negativos:       " + neg);
                Console.WriteLine("Numeros multiplos de 15: " + quin);
                Console.WriteLine("Numeros pares:           " + par);
            }
            Console.ReadKey();
        }
    }
}
