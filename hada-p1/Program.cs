using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            string data;
            double conv;

            do
            {

                Console.WriteLine("--- MENÚ DE CONVERSIÓN ---");
                Console.WriteLine(" 1 - Segundos -> Minutos");
                Console.WriteLine(" 2 - Minutos -> Segundos");
                Console.WriteLine(" 3 - Horas -> Minutos");
                Console.WriteLine(" 4 - Salir");
                Console.WriteLine("Inserta el número de la opción: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\nInserta los segundos que quieres convertir en minutos: ");
                        data = Console.ReadLine();
                        Console.WriteLine("\nSegundos: {0} || Minutos: {1}", data, HadaP1.Seconds2Minutes(Double.Parse(data)));
                        break;
                    case "2":
                        Console.WriteLine("\nInserta los minutos que quieres convertir en segundos: ");
                        data = Console.ReadLine();
                        Console.WriteLine("\nMinutos: {0} || Segundos: {1}", data, HadaP1.Minutes2Seconds(Double.Parse(data)));
                        break;
                    case "3":
                        Console.WriteLine("\nInserta las horas que quieres convertir en horas: ");
                        data = Console.ReadLine();
                        Console.WriteLine("\nHoras: {0} || Minutos: {1}", data, HadaP1.Hours2Minutes(Double.Parse(data)));
                        break;
                    case "4":
                        Console.WriteLine("Hasta luego");
                        break;
                    default:
                        Console.WriteLine("ERROR! - Opción desconocida\n");
                        break;
                }
            } while (opt != "4");
        }
    }
}
