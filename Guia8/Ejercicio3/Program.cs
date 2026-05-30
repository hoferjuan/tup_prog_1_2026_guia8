using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        #region Variables
        static string nombre0, nombre1, nombre2;
        static int numeroLibreta0, numeroLibreta1, numeroLibreta2;
        static int orden;
        #endregion

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            switch (orden)
            {
                case 0:
                    Program.nombre0 = nombre;
                    Program.numeroLibreta0 = numeroLibreta;
                    break;
                case 1:
                    Program.nombre1 = nombre;
                    Program.numeroLibreta1 = numeroLibreta;
                    break;
                case 2:Program.nombre2 = nombre;
                    Program.numeroLibreta2 = numeroLibreta;
                    break;
            }
        }
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            
            Console.WriteLine("1- Registar Libreta de los alumnos");
            Console.WriteLine("2- Mostrar Lista Ordenada");

        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            
            for (int i = 0; i < 3; i++)
            {
                orden = i;
                Console.WriteLine("Ingrese el Nombre del alumno: "+ i + "Luego su Número de Libreta");
                string nombre = Console.ReadLine();
                int numeroLibreta = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroLibreta(nombre, numeroLibreta);
            }
        }
        static void MostrarPantallaListaOrdenada()
        {
            
            if (numeroLibreta0 > numeroLibreta1)
            {
                if (numeroLibreta2 > numeroLibreta0)
                {
                    Console.WriteLine(nombre1 + " " + numeroLibreta1);
                    Console.WriteLine(nombre0 + " " + numeroLibreta0);
                    Console.WriteLine(nombre2 + " " + numeroLibreta2);
                }
                else
                {
                   if (numeroLibreta2 > numeroLibreta1)
                    {
                        Console.WriteLine(nombre1 + " " + numeroLibreta1);
                        Console.WriteLine(nombre2 + " " + numeroLibreta2);
                        Console.WriteLine(nombre0 + " " + numeroLibreta0);
                    }
                    else
                    {
                        Console.WriteLine(nombre2 + " " + numeroLibreta2);
                        Console.WriteLine(nombre1 + " " + numeroLibreta1);
                        Console.WriteLine(nombre0 + " " + numeroLibreta0);
                    }
                }
            }
            else
            {
                if(numeroLibreta2 > numeroLibreta1)
                {
                    Console.WriteLine(nombre0 + " " + numeroLibreta0);
                    Console.WriteLine(nombre1 + " " + numeroLibreta1);
                    Console.WriteLine(nombre2 + " " + numeroLibreta2);
                }
                else
                {
                    if (numeroLibreta2 > numeroLibreta0)
                    {
                        Console.WriteLine(nombre0 + " " + numeroLibreta0);
                        Console.WriteLine(nombre2 + " " + numeroLibreta2);
                        Console.WriteLine(nombre1 + " " + numeroLibreta1);
                    }
                    else
                    {
                        Console.WriteLine(nombre2 + " " + numeroLibreta2);
                        Console.WriteLine(nombre0 + " " + numeroLibreta0);
                        Console.WriteLine(nombre1 + " " + numeroLibreta1);
                    }
                }
            }
        }
        

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarPantallaSolicitarOpcionMenu();

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaListaOrdenada();
                        break;
                }

            } while (opcion != -1);
        }
    }
}
