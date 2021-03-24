using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_3er_corte_AlvMario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables

            int edad = 0;
            int meses = 0;
            int peso = 0;
            int actividad = 0;
            string dato = "";
            int opcion = 0;


            do
            {
                Console.WriteLine("Bienvenido, ¿deseas saber cuanto debe comer tu perro?");
                Console.WriteLine("¿Tu perro es un cachorro o un adulto?");
                Console.WriteLine("1 = cachorro \n2 = adulto");
                dato = Console.ReadLine();
                edad = Convert.ToInt32(dato);


                if (edad == 1)
                {
                    Console.WriteLine("¿Cuanto pesa tu cachorro?");
                    dato = Console.ReadLine();
                    peso = Convert.ToInt32(dato);

                    Console.WriteLine("¿Cuantos meses tiene tu cachorro?");
                    Console.WriteLine("1 = 2 meses \n2 = 3 meses \n3 = 4 meses \n4 = 5 meses \n5 = 6-12 meses");
                    dato = Console.ReadLine();
                    meses = Convert.ToInt32(dato);

                    if (peso == 2)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu cachorro debe comer 50 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu cachorro debe comer 60 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu cachorro debe comer 60 gramos");
                                break;
                            case 4:
                                Console.WriteLine("Tu cachorro debe comer 60 gramos");
                                break;
                            case 5:
                                Console.WriteLine("Tu cachorro debe comer 55 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 5 && peso <= 10)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu cachorro debe comer entre 95 y 155 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu cachorro debe comer entre 110 y 185 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu cachorro debe comer entre 115 y 195  gramos");
                                break;
                            case 4:
                                Console.WriteLine("Tu cachorro debe comer entre 115 y 190 gramos");
                                break;
                            case 5:
                                Console.WriteLine("Tu cachorro debe comer entre 110 y 185 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso == 17)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu cachorro debe comer 215 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu cachorro debe comer 265 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu cachorro debe comer 285 gramos");
                                break;
                            case 4:
                                Console.WriteLine("Tu cachorro debe comer 285 gramos");
                                break;
                            case 5:
                                Console.WriteLine("Tu cachorro debe comer 280 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >=25 && peso <= 32)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu cachorro debe comer entre 270 y 300 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu cachorro debe comer entre 350 y 400 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu cachorro debe comer entre 375 y 445 gramos");
                                break;
                            case 4:
                                Console.WriteLine("Tu cachorro debe comer entre 375 y 450 gramos");
                                break;
                            case 5:
                                Console.WriteLine("Tu cachorro debe comer entre 370 y 450 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 40 && peso <= 50)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu cachorro debe comer entre 355 y 405 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu cachorro debe comer entre 475 y 545 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu cachorro debe comer entre 525 y 610 gramos");
                                break;
                            case 4:
                                Console.WriteLine("Tu cachorro debe comer entre 530 y 625 gramos");
                                break;
                            case 5:
                                Console.WriteLine("Tu cachorro debe comer 530 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso == 60)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer 450 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer 605 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer 685 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso == 70)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer 485 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer 670 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso == 90)
                    {
                        switch (meses)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer 580");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                }
                else if ( edad == 2)
                {

                    Console.WriteLine("¿Cuanto pesa tu perro?");
                    dato = Console.ReadLine();
                    peso = Convert.ToInt32(dato);

                    Console.WriteLine("¿Como consideras la actividad fisica de tu perro?");
                    Console.WriteLine("1 = Actividad alta");
                    Console.WriteLine("2 = Actividad normal");
                    Console.WriteLine("3 = Actividad baja");
                    dato = Console.ReadLine();
                    actividad = Convert.ToInt32(dato);
                    if (peso >= 2 && peso <= 5)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 60 y 155 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 55 y 100 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 45 y 85 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 5 && peso <= 10)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 115 y 190 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 100 y 170 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 85 y 145 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 10 && peso <= 15)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 190 y 255 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 170 y 225 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 145 y 195 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 15 && peso <= 25)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 255 y 380 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 225 y 330 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 195 y 285 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 25 && peso <= 40)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 380 y 535 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 330 y 475 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 285 y 410 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 40 && peso <= 55)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 535 y 680 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 475 y 600 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 410 y 520 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 55 && peso <= 70)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 680 y 820 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 600 y 720 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 520 y 620 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                    else if (peso >= 70 && peso <= 90)
                    {
                        switch (actividad)
                        {
                            case 1:
                                Console.WriteLine("Tu perro debe comer entre 820 y 985 gramos");
                                break;
                            case 2:
                                Console.WriteLine("Tu perro debe comer entre 720 y 870 gramos");
                                break;
                            case 3:
                                Console.WriteLine("Tu perro debe comer entre 620 y 750 gramos");
                                break;
                            default:
                                Console.WriteLine("El valor ingresado no es valido");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El caracter ingresado no es valido");
                }
                Console.WriteLine("¿Deseas realizar una nueva consulta?");
                Console.WriteLine("Presiona cualquier tecla para continuar \nPresiona 4 para finalizar");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                Console.Clear();

            } while (opcion != 4);

        }
    }
}
