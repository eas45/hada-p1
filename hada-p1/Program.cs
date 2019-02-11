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
                Console.WriteLine(" 3 - Salir");
                Console.WriteLine("Inserta el número de la opción: ");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("\nInserta los segundos que quieres convertir en minutos: ");
                        data = Console.ReadLine();
                        Console.WriteLine("\n{0}", HadaP1.Seconds2Minutes(Double.Parse(data)));
                        break;
                    case "2":
                        Console.WriteLine("\nInserta los minutos que quieres convertir en segundos: ");
                        data = Console.ReadLine();
                        Console.WriteLine("\n{0}", HadaP1.Minutes2Seconds(Double.Parse(data)));
                        break;
                    case "3":
                        Console.WriteLine("Hasta luego");
                        break;
                    default:
                        Console.WriteLine("ERROR! - Opción desconocida\n");
                        break;
                }
            } while (opt != "3");
        }
    }
}
