using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura, area, perimetro;
            Console.Write("Ingrese el valor de la base: ");
            base1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de la altura: ");
            altura = double.Parse(Console.ReadLine());
            area = base1 * altura / 2;
            perimetro = base1 * 3;
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimetro = {0}", perimetro);
            Console.ReadKey();
        }
    }
}
