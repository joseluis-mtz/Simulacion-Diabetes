using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Diabetes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Formato, problema y aleatoriedad
            //Formato de consola
            Console.Title = "Simulación de la probabilidad de desarrollar diabetes tipo I y II";
            Console.SetWindowPosition(Console.WindowLeft, Console.WindowTop);
            Console.SetWindowSize(150, 55);

            //Problematica
            Console.WriteLine("*Obtener la probabilidad de que una persona desarrolle diabetes*");
            Console.WriteLine("INTEGRANTES");
            Console.WriteLine(" -Jesús Abraham Raya Gómez \n -Oswaldo Álvarez Juárez \n -Oscar Alexis Rosales Rodrigo \n -José Luis Martínez Castañeda");

            // Aleatorios
            Random a = new Random();
            double random = 0;
            #endregion

            #region Variables TIPO I
            //Variables diabetes tipo 1
            double probabilidadtipoUno = 0, promediotipoUno = 0, probhombretipoUno = 0, probmujertipoUno = 0;
            int conthomtipoUno = 0, contmujtipoUno = 0;
            string sexo = "", raza = "", familiar = "", edad = "", vive = "", pesoUno = "";
            #endregion

            #region Variables TIPO II
            //Variables de diabetes tipo 2
            double probabilidadtiposDos = 0, probhombretiposDos = 0, probmujertiposDos = 0;
            int conthomtiposDos = 0, contmujtiposDos = 0;
            string genero = "", años = "", tabaco = "", alcohol = "", alimentacion = "", sobrepeso = "", diabetesGestacional = "";
            #endregion

            #region Calculo Diabetes TIPO I
            Console.WriteLine("DIABETES TIPO 1");
            for (int i = 0; i < 1000; i++)
            {
                random = Math.Round(a.NextDouble(), 4);
                if (random < 0.564)
                {
                    sexo = "Hombre";
                    conthomtipoUno++;
                    probabilidadtipoUno = 15;
                    random = Math.Round(a.NextDouble(), 4);
                    //Tipo de raza y edad
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        raza = "Negro";
                        random = Math.Round(a.NextDouble(), 4);
                        if (random > 0 && random < 0.3799)
                        {
                            edad = "0-20";
                            probabilidadtipoUno = (probabilidadtipoUno + 0.24);
                        }
                        else if (random > 0.3799 && random < 0.6879)
                        {
                            edad = "21-40";
                            probabilidadtipoUno = (probabilidadtipoUno + 2.67);
                        }
                        else
                        {
                            edad = "41-80";
                            probabilidadtipoUno = (probabilidadtipoUno + 67.32);
                        }
                    }
                    else
                    {
                        raza = "Blanco";
                        random = Math.Round(a.NextDouble(), 4);
                        if (random > 0 && random < 0.3799)
                        {
                            edad = "0-20";
                            probabilidadtipoUno = (probabilidadtipoUno + 0.2);
                        }
                        else if (random > 0.3799 && random < 0.6879)
                        {
                            edad = "21-40";
                            probabilidadtipoUno = (probabilidadtipoUno + 2.23);
                        }
                        else
                        {
                            edad = "41-80";
                            probabilidadtipoUno = (probabilidadtipoUno + 56.10);
                        }
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        familiar = "Si";
                        probabilidadtipoUno = probabilidadtipoUno + (15 + (15 * 0.5));
                    }
                    else
                    {
                        familiar = "No";
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random > 0 && random < 0.6)
                    {
                        vive = "Zona Urbana Industrial   ";
                        probabilidadtipoUno = probabilidadtipoUno + (15 + (15 * 0.1));
                    }
                    else if (random > 0.6 && random < 0.95)
                    {
                        vive = "Zona Urbana NO Industrial";
                        probabilidadtipoUno = probabilidadtipoUno + (15 + (15 * 0.03));
                    }
                    else
                    {
                        vive = "Zona Rural               ";
                        probabilidadtipoUno = probabilidadtipoUno + (15 + (15 * 0.15));
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        pesoUno = "Si";
                        probabilidadtipoUno = probabilidadtipoUno + (15 + (15 * 0.04));
                    }
                    else
                    {
                        pesoUno = "No";
                    }
                }
                else
                {
                    sexo = "Mujer";
                    contmujtipoUno++;
                    probabilidadtipoUno = 7;
                    //¿Ha fumado?
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        raza = "Negro";
                        random = Math.Round(a.NextDouble(), 4);
                        if (random > 0 && random < 0.3490)
                        {
                            edad = "0-20";
                            probabilidadtipoUno = (probabilidadtipoUno + 0.09);
                        }
                        else if (random > 0.3490 && random < 0.6648)
                        {
                            edad = "21-40";
                            probabilidadtipoUno = (probabilidadtipoUno + 1.45);
                        }
                        else
                        {
                            edad = "41-80";
                            probabilidadtipoUno = (probabilidadtipoUno + 19.28);
                        }
                    }
                    else
                    {
                        raza = "Blanco";
                        random = Math.Round(a.NextDouble(), 4);
                        if (random > 0 && random < 0.3490)
                        {
                            edad = "0-20";
                            probabilidadtipoUno = (probabilidadtipoUno + 0.1);
                        }
                        else if (random > 0.3490 && random < 0.6648)
                        {
                            edad = "21-40";
                            probabilidadtipoUno = (probabilidadtipoUno + 1.62);
                        }
                        else
                        {
                            edad = "41-80";
                            probabilidadtipoUno = (probabilidadtipoUno + 21.43);
                        }
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        familiar = "Si";
                        probabilidadtipoUno = probabilidadtipoUno + (7 + (7 * 0.5));
                    }
                    else
                    {
                        familiar = "No";
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random > 0 && random < 0.6)
                    {
                        vive = "Zona Urbana Industrial   ";
                        probabilidadtipoUno = probabilidadtipoUno + (7 + (7 * 0.15));
                    }
                    else if (random > 0.6 && random < 0.95)
                    {
                        vive = "Zona Urbana NO Industrial";
                        probabilidadtipoUno = probabilidadtipoUno + (7 + (7 * 0.1));
                    }
                    else
                    {
                        vive = "Zona Rural               ";
                        probabilidadtipoUno = probabilidadtipoUno + (7 + (7 * 0.03));
                    }

                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        pesoUno = "Si";
                        probabilidadtipoUno = probabilidadtipoUno + (7 + (7 * 0.04));
                    }
                    else
                    {
                        pesoUno = "No";
                    }
                }

                probabilidadtipoUno = probabilidadtipoUno / 6;
                if (sexo == "Hombre")
                {
                    probhombretipoUno = probhombretipoUno + probabilidadtipoUno;
                }
                else
                {
                    probmujertipoUno = probmujertipoUno + probabilidadtipoUno;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Género\tEdad\tRaza\t    Familiares con diabetes\t        Tiene sobrepeso        \tVive en\t                        Probabilidad");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(sexo + "\t" + edad + "\t" + raza + "\t    " + familiar + "\t\t\t\t\t" + pesoUno + "\t\t\t" + vive + "\t" + Math.Round(probabilidadtipoUno, 4));
                probabilidadtipoUno = 0;
            }
            #endregion

            #region Pausa de ejecución
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadKey();
            #endregion

            #region Calculo Diabetes TIPO II
            Console.WriteLine("DIABETES TIPO 2");
            for (int p = 0; p < 1000; p++)
            {
                random = Math.Round(a.NextDouble(), 4);
                if (random < 0.487)
                {
                    genero = "Hombre";
                    conthomtiposDos++;
                    probabilidadtiposDos = 6;
                    random = Math.Round(a.NextDouble(), 4);
                    //fumar
                    if (random < 0.5)
                    {
                        tabaco = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 23;
                    }
                    else
                    {
                        tabaco = "No";
                    }
                    //alcohol
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        alcohol = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 4.6;
                    }
                    else
                    {
                        alcohol = "No";
                    }
                    // edad
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.14)
                    {
                        años = " 0-14";
                        probabilidadtiposDos = probabilidadtiposDos + 5.79;
                    }
                    else
                    {
                        años = "15-80";
                        probabilidadtiposDos = probabilidadtiposDos + 20.473;
                    }
                    //alimentacion
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        alimentacion = "Mala";
                        probabilidadtiposDos = probabilidadtiposDos + 6.1;
                        ///sobrepeso
                        random = Math.Round(a.NextDouble(), 4);
                        if (random < 0.5)//si
                        {
                            sobrepeso = "Si";
                            probabilidadtiposDos = probabilidadtiposDos + 4.1;
                        }
                        else
                        {
                            sobrepeso = "No";
                        }
                    }
                    else
                    {
                        alimentacion = "Normal";
                    }

                    //////diabetesGestacional
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.60)
                    {
                        diabetesGestacional = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 20;
                    }
                    else
                    {
                        diabetesGestacional = "No";
                    }
                }
                else
                {
                    genero = "Mujer";
                    contmujtiposDos++;
                    probabilidadtiposDos = 5;
                    random = Math.Round(a.NextDouble(), 4);
                    //fumar
                    if (random < 0.5)
                    {
                        tabaco = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 15.6;
                    }
                    else
                    {
                        tabaco = "No";
                    }
                    //alcohol
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        alcohol = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 3.3;
                    }
                    else
                    {
                        alcohol = "No";
                    }
                    // edad
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.134)
                    {
                        años = " 0-14";
                        probabilidadtiposDos = probabilidadtiposDos + 4.865;
                    }
                    else
                    {
                        años = "15-80";
                        probabilidadtiposDos = probabilidadtiposDos + 24.635;
                    }
                    //alimentacion
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.5)
                    {
                        alimentacion = "Mala";
                        probabilidadtiposDos = probabilidadtiposDos + 3.4;
                        //sobrepeso
                        random = Math.Round(a.NextDouble(), 4);
                        if (random < 0.5)//si
                        {
                            sobrepeso = "Si";
                            probabilidadtiposDos = probabilidadtiposDos + 6.9;
                        }
                        else
                        {
                            sobrepeso = "No";
                        }
                    }
                    else
                    {
                        alimentacion = "Normal";
                    }
                    ///diabetesGestacional
                    random = Math.Round(a.NextDouble(), 4);
                    if (random < 0.60)
                    {
                        diabetesGestacional = "Si";
                        probabilidadtiposDos = probabilidadtiposDos + 20;
                    }
                    else
                    {
                        diabetesGestacional = "No";
                    }
                }

                probabilidadtiposDos = probabilidadtiposDos / 8;

                if (genero == "Hombre")
                {
                    probhombretiposDos = probhombretiposDos + probabilidadtiposDos;
                }
                else
                {
                    probmujertiposDos = probmujertiposDos + probabilidadtiposDos;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Género\tFuma\tBebe\tEdad\tAlimentación\tSobrepeso       Diabetes gestacional      Probabilidad");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(genero + "\t" + tabaco + "\t" + alcohol + "\t" + años + "\t" + alimentacion + "    \t" + sobrepeso + "        \t" + diabetesGestacional + "\t\t          " + Math.Round(probabilidadtiposDos, 4));
                probabilidadtiposDos = 0;
            }
            #endregion

            #region Resultados TIPO I
            Console.ForegroundColor = ConsoleColor.White;
            //Probabilidad diabetes de tipo I
            promediotipoUno = probhombretipoUno / conthomtipoUno;
            Console.WriteLine("\nDIABETES TIPO 1");
            Console.Write("La probabilidad de que un hombre desarrolle diabetes tipo I es de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Round(promediotipoUno, 4) + "%");
            Console.ForegroundColor = ConsoleColor.White;
            promediotipoUno = probmujertipoUno / contmujtipoUno;
            Console.Write("La probabilidad de que una mujer desarrolle diabetes tipo I es de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Round(promediotipoUno, 4) + "%");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Resultados TIPO II
            Console.ForegroundColor = ConsoleColor.White;
            //Probabilidad diabetes de tipo II
            probhombretiposDos = probhombretiposDos / conthomtiposDos;
            Console.WriteLine("\nDIABETES TIPO 2");
            Console.Write("La probabilidad de que un hombre desarrolle diabetes tipo II es de  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Round(probhombretiposDos, 4) + "%");
            Console.ForegroundColor = ConsoleColor.White;
            probmujertiposDos = probmujertiposDos / contmujtiposDos;
            Console.Write("La probabilidad de que una mujer desarrolle diabetes tipo II es de  ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Round(probhombretiposDos, 4) + "%");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            Console.ReadKey();
        }
    }
}