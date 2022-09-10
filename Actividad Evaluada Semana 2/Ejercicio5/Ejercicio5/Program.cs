using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese sus datos: ");
            Console.Write("Nombre: ");
            String nombre;
            nombre = Console.ReadLine();
            Console.Write("Edad: ");
            double edad;
            edad = double.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            double peso;
            peso = double.Parse(Console.ReadLine());
            Console.Write("Estatura: ");
            double estatura;
            estatura = double.Parse(Console.ReadLine());
            Console.Write("Tipo de sangre: ");
            String tsangre;
            tsangre = Console.ReadLine();

            Console.WriteLine("Sus datos son. ");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Estatura: " + estatura);
            Console.WriteLine("Tipo de sangre: " + tsangre);
            Console.ReadKey();

        }
    }
}
