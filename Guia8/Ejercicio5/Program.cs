using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        #region Lógica
        static int DeterminarLosDiasDelMes(int mes, int anio)
        {
            int dias = 0;
            if (mes < 7)
            {
                if (mes == 2)
                {
                    if (DeterminarSiEsBisiesto(anio))
                    {
                        dias = 29;
                    }
                    else
                    {
                        dias = 28;
                    }
                }
                else
                {
                    if (mes % 2 != 0)
                    {
                        dias = 31;
                    }
                    else
                    {
                        dias = 30;
                    }
                }
            }
            else
            {
                if (mes >= 7)
                {
                    if (mes % 2 != 0)
                    {
                        dias = 30;
                    }
                    else
                    {
                        dias = 31;
                    }
                }
            }
            return dias;
        }
        static bool DeterminarSiEsBisiesto(int anio)
        {
            if (anio % 400 == 0)
            {
                return true;
            }
            else
            {
                if (anio % 100 == 0)
                {
                    return false;
                }
                else
                {
                    if (anio % 4 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        #endregion
        //Mostrar Pantallas
        #region MostrarPantallas
        static void MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1- Determinar Cantidad de Días del mes.\r\n2- Verificar Si el año es bisiesto.\r\n");
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.WriteLine("Ingrese año");
            int anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese mes");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" El mes tiene " + DeterminarLosDiasDelMes(mes, anio) + " Días ");

        }
        static void MostrarPantallaSolicitarSiElAñoEsBisiesto()
        {
            Console.WriteLine("Ingrese el año");
            int anio = Convert.ToInt32(Console.ReadLine());
            if (DeterminarSiEsBisiesto(anio))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
        }
        #endregion
        static void Main(string[] args)
        {

            MostrarPantallaSolicitarOpcionMenu();
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MostrarPantallaSolicitarMesAñoYDeterminarDias();
                    break;
                case 2:
                    MostrarPantallaSolicitarSiElAñoEsBisiesto();
                    break;
            }
        }
    }
}
