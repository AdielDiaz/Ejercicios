using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, area, radio, volumen;
            Console.Write("Ingres el valor de la altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del radio: ");
            radio = double.Parse(Console.ReadLine());
            volumen = Math.PI * radio * altura;
            area = 2.0 * Math.PI * radio * (radio + altura);
            Console.WriteLine("El valor del area es: " + area);
            Console.WriteLine("El valor del volumen es: " + volumen);
            Console.ReadKey();
        }
    }
}
