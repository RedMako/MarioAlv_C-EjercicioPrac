using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erCorteMarioAlv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables declaradas

            string first = "";
            int x = 0;

            string second = "";
            int y = 0;

            string third = "";
            int z = 0;

            //Programa

            Console.WriteLine("Ingresa tu primer numero");
            first = Console.ReadLine();
            x = Convert.ToInt32(first);

            Console.WriteLine("Ingresa tu segundo numero");
            second = Console.ReadLine();
            y = Convert.ToInt32(second);

            Console.WriteLine("Ingresa tu tercer numero");
            third = Console.ReadLine();
            z = Convert.ToInt32(third);

            Console.WriteLine("La combinación de números es: {0}{1}{2}", x, y, z);
            Console.WriteLine("Presiona cualquier tecla para mostrar los codigos secretos");
            Console.ReadKey(true);

            Console.WriteLine("Codigos secretos");

            //aacb
            Console.WriteLine("Primer codigo: {0}{0}{2}{1}", x, y, z);

            //bca 
            Console.WriteLine("Segundo codigo: {1}{2}{0}", x, y, z);

            //bcbc
            Console.WriteLine("Tercer codigo: {0}{1}{0}{1}", y, z);
            Console.ReadKey(true);
        }
    }
}
