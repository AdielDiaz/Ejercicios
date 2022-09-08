using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";
            while (resp == "s" || resp == "s") ;
            int Num1 = 0;
            int Num2 = 0;
            int resul = 0;
            Console.WriteLine("Escriba un numero para realizar la operacion.");
            Console.WriteLine("1 para sumar");
            Console.WriteLine("2 para restar");
            Console.WriteLine("3 para multiplicar");
            Console.WriteLine("4 para dividir");
            Console.Write("Eliga Una Opcion: ");
            resp = Console.ReadLine();
            string eleccion = Convert.ToString(resp);
            Console.WriteLine("Ingrese los numeros que desea operar: ");
            Console.Write("Num1: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (eleccion)
            {
                case "1":
                    Console.WriteLine("El resultado es: ");
                    resul = Num1 + Num2;
                    Console.WriteLine("{0} + {1} = {2}", Num1, Num2, resul);
                    break;
                case "2":
                    Console.WriteLine("El resultado es: ");
                    resul = Num1 - Num2;
                    Console.WriteLine("{0} - {1} = {2}", Num1, Num2, resul);
                    break;
                case "3":
                    Console.WriteLine("El resultado es: ");
                    resul = Num1 * Num2;
                    Console.WriteLine("{0} * {1} = {2}", Num1, Num2, resul);
                    break;
                case "4":
                    Console.WriteLine("El resultado es: ");
                    resul = Num1 / Num2;
                    Console.WriteLine("{0} / {1} = {2}", Num1, Num2, resul);
                    break;
            }
            Console.WriteLine("¿Desea continuar? s/n: ");
            resp = Console.ReadLine();
        }
    }
}
