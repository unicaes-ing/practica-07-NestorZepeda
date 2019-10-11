using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine();
                Console.WriteLine("********************************************");
                Console.WriteLine("                 Practica 7");
                Console.WriteLine("********************************************");
                Console.WriteLine();
                Console.WriteLine("Seleccione ejercicios de practica 7");
                Console.WriteLine();
                Console.WriteLine("1-)Ejercicio 1");
                Console.WriteLine("2-)Ejercicio 2");
                Console.WriteLine("3-)Ejercicio 3");
                Console.WriteLine("4-)Ejercicio 4");
                Console.WriteLine("5-)Ejercicio 5");
                Console.WriteLine("6-)Ejercicio 6");
                Console.WriteLine("7-)Salir");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ejercicio1();
                        break;

                    case 2:
                        ejercicio2();
                        break;

                    case 3:
                        ejercicio3();
                        break;

                    case 4:
                        ejercicio4();
                        break;

                    case 5:
                        ejercicio5();
                        break;
                    case 6:
                        ejercicio6();
                        break;
                    default:
                        break;
                }
            } while (op != 7);
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
            Environment.Exit(1);
        }


        static void ejercicio1()
        {
            int can = 0, canmayor = 0;
            int[] edades;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de personas");
            int n = Convert.ToInt32(Console.ReadLine());
            edades = new int[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Ingrese la edad " + i);
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades[i] < 18)
                {
                    can = can + 1;
                }
                else
                    if (edades[i] >= 18)
                { canmayor = canmayor + 1; }
            }

            Console.WriteLine("*********************");
            Console.WriteLine("Menores de edad: " + can);
            Console.WriteLine("*********************");
            Console.WriteLine("Mayores de edad: " + canmayor);
            Console.ReadKey();
        }
        static void ejercicio2()
        {
            Console.Clear();
            int canpares = 0, caninpares = 0;
            int[] numeros;
            Console.WriteLine("Ingrese la cantidad de numeros");
            int n = Convert.ToInt32(Console.ReadLine());
            numeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el " + i + "° numero");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    canpares = canpares + 1;
                }
                else
                {
                    caninpares = caninpares + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("Números Pares: " + canpares);
            Console.WriteLine("*********************");
            Console.WriteLine("Números Inparares: " + caninpares);
            Console.WriteLine("*********************");
            Console.ReadKey();
        }
        static void ejercicio3()
        {
            Console.Clear();
            int N = 0;
            int cequipos;
            string[] nombre = new string[N];


            Console.WriteLine("Ingrese la cantidad equipos:");
            cequipos = Convert.ToInt32(Console.ReadLine());
            string[] nombreequipo = new string[cequipos];
            for (int i = 0; i < cequipos; i++)
            {

                Console.WriteLine("Ingrese el nombe del equipo {0}", i + 1);
                nombreequipo[i] = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de jugadores que hay en su equipo:");
                N = Convert.ToInt32(Console.ReadLine());
                nombre = new string[N];
                for (int O = 0; O < N; O++)
                {
                    Console.WriteLine("Ingrese nombre del jugador {0} ", O + 1);
                    nombre[O] = Console.ReadLine();
                }
            }
            Console.WriteLine("Presione cualquier tecla para mostrar los datos ingresados");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine();

            for (int i = 0; i < nombreequipo.Length; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("Nombre del equipo :  " + nombreequipo[i]);
                Console.WriteLine("********************************************");
                Console.WriteLine();
                for (int O = 0; O < nombre.Length; O++)
                {

                    Console.WriteLine("Nombre del jugador {0}:{1}", O + 1, nombre[O]);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

        }
        static void ejercicio4()
        {
            Console.WriteLine("MATRIZ DE 5x5");
            Console.WriteLine();
            int[,] matriz = new int[5, 5];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Ingrese el valor de la posición ({0},{1}): ", f + 1, c + 1);
                    matriz[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            trans(matriz);
            Console.ReadKey();
        }

        static void trans(int[,] matriz)
        {
            Console.WriteLine("MATRIZ TRANSVERSA");
            Console.WriteLine();
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[c, f] + "  ");
                }
                Console.WriteLine();
            }
        }
    

        static void ejercicio5()
        {
            Console.Clear();
            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("Matriz #" + (a + 1));
                Console.WriteLine();
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("Valor de la posición ({0},{1}): ", f + 1, c + 1);
                        if (a == 0)
                        {
                            matriz1[f, c] = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            matriz2[f, c] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                Console.Clear();
            }
            sumar(matriz1, matriz2);
            Console.ReadKey();
        }

        static void sumar(int[,] matriz1, int[,] matriz2)
        {
            int[,] Sum = new int[3, 3];
            Console.WriteLine("Resultado de la suma de 2 matrices");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Sum[f, c] = matriz1[f, c] + matriz2[f, c];
                    Console.Write(Sum[f, c] + "  ");
                }
                Console.WriteLine();
            }
        }
    
        static void ejercicio6()
        {
            Console.Clear();
                Random rnd = new Random();
                int[,] arreglo = new int[6, 6];
                for (int f = 0; f < 6; f++)
                {
                    for (int c = 0; c < 6; c++)
                    {
                        
                            int num = rnd.Next(10, 100);
                            arreglo[f, c] = num;
                    
                        for (int i = 0; i < arreglo.Length; i++)
                        {

                            if (num == arreglo.Length)
                            {
                                num = rnd.Next(10, 100);
                                arreglo[f, c] = num;
                            }
                        
                        }
                     
                    }
                }

                for (int a = 0; a < 6; a++)
                {
                    for (int b = 0; b < 6; b++)
                    {
                        Console.Write(arreglo[a, b] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
    }
}

