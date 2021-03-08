using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numT, l1 = 0, l2 = 0, l3 = 0, eq = 0, iso = 0, esca = 0;
            Console.WriteLine("Ingrese el numero de triangulos a evaluar...");
            try
            {
                numT = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato no aceptado. Solo debe ingresar valores numericos");
                Console.WriteLine("Al presionar una tecla el programa se cerrara...");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < numT; i++)
            {
                try
                {
                    Console.WriteLine("Ingrese el valor de uno de sus lados");
                    l1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de otro de sus lados");
                    l2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de otro lado mas");
                    l3 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato no aceptado. Solo debe ingresar valores numericos");
                    Console.WriteLine("Al presionar una tecla el programa se cerrara...");
                    Console.ReadKey();
                    return;
                }
                if (l1 == l2 && l2 == l3)
                {
                    eq++;
                }

                else if (l1 != l2 && l1 == l3 && l2 == l3)
                {
                    iso++;
                }
                else if (l1 != l2 && l1 != l3 && l2 == l3)
                {
                    iso++;
                }
                else if (l1 == l2 && l1 == l3 && l2 != l3)
                {
                    iso++;
                }
                else if (l1 == l2 && l1 != l3 && l2 != l3)
                {
                    iso++;
                }
                else if (l1 != l2 && l1 == l3 && l2 != l3)
                {
                    iso++;
                }

                else if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    esca++;
                }
                Console.WriteLine("Numero de triangulos equilateros: " + eq);
                Console.WriteLine("Numero de triangulos isoceles:    " + iso);
                Console.WriteLine("Numero de triangulos escalenos:   " + esca);
                l1 = 0; l2 = 0; l3 = 0;
            }
            Console.ReadKey();
        }
    }
}
