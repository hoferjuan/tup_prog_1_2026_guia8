using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        #region variables
        static int edad0, edad1, edad2, edad3;
        static double monto, monto0, monto1, monto2, monto3;
        static double porcentaje0, porcentaje1, porcentaje2, porcentaje3;
        #endregion
        static void RegistrarMontoARepartir(double monto)
        {
            Program.monto = monto;
        }
        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0: edad0 = edad; break;
                case 1: edad1 = edad; break;
                case 2: edad2 = edad; break;
                case 3: edad3 = edad; break;
            }
        }
        static void CalcularMontosYPorcentajesARepartir()
        {
            int sumaedades = edad0 + edad1 + edad2 + edad3;

            //Calculo del Porcentaje
            porcentaje0 = ((double)edad0 / sumaedades) * 100;
            porcentaje1 = ((double)edad1 / sumaedades) * 100;
            porcentaje2 = ((double)edad2 / sumaedades) * 100;
            porcentaje3 = ((double)edad3 / sumaedades) * 100;

            //Calculo de montos
            monto0 = (porcentaje0 * monto) / 100;
            monto1 = (porcentaje1 * monto) / 100;
            monto2 = (porcentaje2 * monto) / 100;
            monto3 = (porcentaje3 * monto) / 100;
        }
        #region PintarPantalla
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Iniciar Monto a repartir\r\n2- Solicitar Edad Por niña\r\n3- Mostrar monto y porcentajes que corresponde a cada niña\r\n(-1) SALIR");
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.WriteLine("Ingrese el monto a repartir");
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.WriteLine("Ingrese las edades de las niñas");
        }
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.WriteLine($"Ana Paula su monto es {monto0:F2}, Su porcentaje: % {porcentaje0:F2}");
            Console.WriteLine($"Lucía su monto es {monto1:F2}, Su porcentaje: % {porcentaje1:F2}");
            Console.WriteLine($"Milena su monto es {monto2:F2}, Su porcentaje: % {porcentaje2:F2}");
            Console.WriteLine($"Jazmín su monto es {monto3:F2}, Su porcentaje: % {porcentaje3:F2}");
        }
        #endregion
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
                        MostrarPantallaSolicitarMontoARepartir();
                        double monto = Convert.ToDouble(Console.ReadLine());
                        RegistrarMontoARepartir(monto);
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Ingrese la edad de la niña  " + i);
                            int edad = Convert.ToInt32(Console.ReadLine());
                            RegistrarEdad(edad, i);
                        }
                        break;
                    case 3:
                        CalcularMontosYPorcentajesARepartir();
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        Console.ReadKey();
                        break;
                }

            } while (opcion != -1);
        }
    }
}
