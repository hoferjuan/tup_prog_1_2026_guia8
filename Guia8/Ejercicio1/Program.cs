using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static int acumulador = 0, contador = 0;
        static int maximo=0, minimo=0;

        static void RegistrarValor(int valor)
        {
            //Cuento y acumulo el valor
            contador++;
            acumulador += valor;

            //Verifico Valores
            if (contador == 1)
            {
                maximo = valor;
                minimo = valor;
                    
            }
            if (valor > maximo)
            {
                maximo = valor;
            }
            if (valor < minimo)
            {
                minimo = valor;
            }
            
        }
        static double CalcularPromedio()
        { 
            double promedio=0;
            if (contador > 0)
            {
                promedio = (double)acumulador / contador;
            }
            return promedio;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            int opcion = 0;
            Console.WriteLine("Ingresar Opción");
            Console.WriteLine("\r\n1- Procesar un solo número\r\n2- Procesar varios números\r\n3- Mostrar máximo y mínimo.\r\n4- Mostrar promedio.\r\n5- Mostrar cantidad de números ingresados.\r\n6- Reiniciar variables.\r\n7- Salir.");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        static void MostrarIniciarVariables()
        {
            Console.Clear();
            contador=0; acumulador = 0; maximo = 0; minimo = 0;
            Console.WriteLine("Se reiniciaron las variables");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número");
            int num = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(num);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            int num;
            do
            {
                Console.WriteLine("Ingrese un Número (-1) Para salir");
                num = Convert.ToInt32(Console.ReadLine());
                if(num != -1)
                {
                    RegistrarValor(num);
                }

            }while (num != -1);
        }
        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine($"El máximo es  {maximo}");
            Console.WriteLine($"El minimo es  {minimo}");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine($"El promedio es {CalcularPromedio()}");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine($"La Cantidad de números ingresados es {contador}");
            Console.ReadKey();
        }




        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarNumero(); break;
                    case 2: MostrarPantallaSolicitarVariosNumeros(); break;
                    case 3: MostrarPantallaMaximoYMinimo(); break;
                    case 4: MostrarPantallaCalcularYMostrarPromedio(); break;
                    case 5: MostrarPantallaCantidad(); break;
                    case 6: MostrarIniciarVariables(); break;
                    default:
                        Console.WriteLine("Opción inválida"); break;
                } 
            } while (opcion != 7);
            

        }
    }
}
