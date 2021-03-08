using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int par, x = 0, y = 0;
            Console.WriteLine("Ingrese el numero de pares ordenados a procesar...");
            try
            {
                par = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato, SOLO DEBE INGRESAR NUMEROS...");
                Console.WriteLine("El programa se cerrara al presionar una tecla");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < par; i++)
            {
                try
                {
                    Console.WriteLine("Ingrese el valor de la coordenada 'x'");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la coordenada 'y'");
                    y = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error de formato, SOLO DEBE INGRESAR NUMEROS...");
                    Console.WriteLine("El programa se cerrara al presionar una tecla");
                    Console.ReadKey();
                    return;
                }
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("La coordenada (" + x + "," + y + ") se encuentra en el cuadrante I");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("La coordenada (" + x + "," + y + ") se encuentra en el cuadrante II");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("La coordenada (" + x + "," + y + ") se encuentra en el cuadrante III");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("La coordenada (" + x + "," + y + ") se encuentra en el cuadrante IV");
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine("La coordenada (" + x + "," + y + ") se encuentra en el origen");
                }
            }
            Console.ReadKey();
        }
    }
}
