using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad en horas: ");
            double horas = double.Parse(Console.ReadLine());
            double minutos = horas * 60;
            double segundos = horas * 3600;
            Console.WriteLine("Equivalencia en minutos: " + minutos);
            Console.WriteLine("Equivalencia en segundos: " + segundos);
            Console.ReadKey();

        }
    }
}
