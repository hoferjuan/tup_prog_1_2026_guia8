using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio4
{
    internal class Program
    {
        //Variables
        static string jugador1, jugador2;
        static int setGanados1, setGanados2;

        #region Lógica
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        static void RegistrarResultados(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else
            {
                setGanados2++;
            }

        }
        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return "El Ganador es :" + jugador1;
            }
            else
            {
                return "El Ganador es :" + jugador2;
            }
        }
        #endregion

        //Mostrar Pantallas
        #region MostrarPantallas
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1- Registrar los nombres de los dos jugadores.\r\n2- Registrar los resultados de cada set de los jugadores.\r\n3- Mostrar el ganador.\r\n");
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.WriteLine("Ingrese nombre del Jugador N°:1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del Jugador N°:2");
            string nombre2 = Console.ReadLine();
            RegistrarJugadores(nombre1, nombre2);
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            //SET1
            Console.WriteLine("Ingrese Puntos SET 1 jugador N°1: ");
            int resultado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Puntos SET 1 jugador N°2: ");
            int resultado2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultados(resultado1, resultado2);

            //SET2
            Console.WriteLine("Ingrese Puntos SET 2 jugador N°1: ");
            resultado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Puntos SET 2 jugador N°2: ");
            resultado2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultados(resultado1, resultado2);

            //SET3
            Console.WriteLine("Ingrese Puntos SET 3 jugador N°1: ");
            resultado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Puntos SET 3 jugador N°2: ");
            resultado2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultados(resultado1, resultado2);


        }
        static void MostrarPantallaGanador()
        {
            Console.WriteLine($"El ganador del partido es: {DeterminarGanador()}");
        }
        #endregion
        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();
            
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MostrarPantallaSolicitarNombreJugadores();
                    break;
                case 2:
                    MostrarPantallaSolicitarResultadoSet();
                    break;
                case 3:
                    MostrarPantallaGanador();
                    break;
            }
        }
    }
}
