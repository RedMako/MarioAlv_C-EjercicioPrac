using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Segundo_Corte_Mario_Alv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Segundo corte de Programación I (Estudiante: Mario Alvarado)
            // Declaración de variables 

            string texto = "";
            int    edad;
            double estatura = 0.0;

            // Programa 

            Console.WriteLine("Bievenido a *insertar nombre generico de parque*");
            Console.WriteLine("Ingresa tu edad para poder ingresar al parque");
            texto = Console.ReadLine();
            edad = Convert.ToInt32(texto);
            Console.WriteLine("");


            if (edad < 17)
            {
                Console.WriteLine("Lo sentimos eres muy pequeño para ingresar, necesitas por lo menos 17 años");
                Console.WriteLine("Presiona cualquier para continuar...");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Perfecto, cumples con la edad minima requerida");
                Console.WriteLine("Por favor, ingresa tu altura para informarte sobre las atracciones disponibles");
                texto = Console.ReadLine();
                estatura = Convert.ToDouble(texto);
                Console.WriteLine("");

                Console.WriteLine("¿Entonces mides " + texto + " metros?");
                Console.WriteLine("Presiona cualquier tecla para descubrir que atracciones estan disponibles para ti");
                Console.ReadKey();
                Console.WriteLine("");


                if (estatura < 1.45)
                {
                    Console.WriteLine("Las atracciones disponibles para ti son:");
                    Console.WriteLine("+ Castillo del terror");
                    Console.WriteLine("+ El carrusel");
                    Console.WriteLine("+ Laser Tag");
                    Console.WriteLine("+ Toboganes");
                    Console.WriteLine("");
                    Console.WriteLine("¡Disfruta al maximo!");
                }

                else
                {
                    Console.WriteLine("Las atracciones disponibles para ti son:");
                    Console.WriteLine("+ Casa embrujada");
                    Console.WriteLine("+ El carrusel");
                    Console.WriteLine("+ Toboganes");
                    Console.WriteLine("+ Carros chocones");
                    Console.WriteLine("+ Laser Tag");
                    Console.WriteLine("+ La Bailarina");
                    Console.WriteLine("+ El Martillo");
                    Console.WriteLine("+ Montaña Rusa");
                    Console.WriteLine("");
                    Console.WriteLine("¡Disfruta al maximo!");
                }
                Console.ReadKey();
            }
        }
    }
}
